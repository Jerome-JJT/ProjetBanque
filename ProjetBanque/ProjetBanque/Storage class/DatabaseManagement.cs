using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace ProjetBanque
{
    /// <summary>
    /// Execute SQL queries on banque database and return success or result
    /// </summary>
    public class DatabaseManagement
    {
        private MySqlConnection connection;

        /// <summary>
        /// Create database instance and init connection
        /// </summary>
        public DatabaseManagement()
        {
            InitConnection();
        }


        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        private void InitConnection()
        {
            // Creation of the connection string : where, who
            // Avoid user id and pwd hardcoded
            string connectionString = "SERVER=127.0.0.1; DATABASE=Banking; UID=BankConnector; PASSWORD=12345678";
            connection = new MySqlConnection(connectionString);
        }


        /// <summary>
        /// Open connection to the database
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                connection.Open(); 
            }
            catch (MySqlException)
            {
                throw new UnableToJoinDatabase();
            }
        }


        /// <summary>
        /// Create and generate a unique IBAN by looking in the database if it exist
        /// </summary>
        /// <returns>full unique IBAN</returns>
        public string GenerateIBAN()
        {
            Random rand = new Random();
            string ibanPrefix = "CH";
            string testIban = null;

            do
            {
                int ibanId = rand.Next(Convert.ToInt32(Math.Pow(10, 0)), Convert.ToInt32(Math.Pow(10, 5)));

                testIban = $"{ibanPrefix}{ibanId.ToString("00 000")}";

                // Create a SQL query
                MySqlCommand query = connection.CreateCommand();
                query.CommandText = "select null from USERS where iban = (@iban)";

                // Add parameters to query
                query.Parameters.AddWithValue("@iban", testIban);

                //Get hashed and salted password from the database
                DbDataReader reader = query.ExecuteReader();
                if(reader.HasRows)
                {
                    testIban = null;
                }
                reader.Close();

            } while (testIban == null);

            return testIban;
        }


        /// <summary>
        /// Add a user in the database with 0 money
        /// </summary>
        /// <param name="email">User's email, will be verified with regex</param>
        /// <param name="password">User's password, will be hashed and salted</param>
        /// <param name="type">Account type, "Public" or "Enterprise", "Admin" can't be added here</param>
        /// <returns>1 if success, 0 for an error</returns>
        public bool AddUser(string email, string password, string type)
        {
            return AddUser(email, password, type, 0);
        }


        /// <summary>
        /// Add a user in the database with a certain amount of money
        /// </summary>
        /// <param name="email">User's email, will be verified with regex</param>
        /// <param name="password">User's password, will be hashed and salted</param>
        /// <param name="type">Account type, "Public" or "Enterprise", "Admin" can't be added here</param>
        /// <param name="money">Base money for the account</param>
        /// <returns>true if success, false for an error</returns>
        public bool AddUser(string email, string password, string type, double money)
        {
            //Allow only Public or Entreprise account creation
            if (!(new List<string> { "Public", "Enterprise" }).Contains(type))
            {
                throw new WrongAccountTypeException();
            }

            try
            {
                //Check email format with microsoft default format, raise exception if wrong
                MailAddress addr = new MailAddress(email);

                //Check if email formatting has changed user's email, if so, raise exception
                if (!(addr.Address == email))
                {
                    throw new WrongEmailFormatException();
                }
            }
            //Wrong format case
            catch (FormatException)
            {
                throw new WrongEmailFormatException();
            }
            //Empty email adress case
            catch (ArgumentException)
            {
                throw new WrongEmailFormatException();
            }


            //Hash and salt password
            CryptoPassword cryptoFunctions = new CryptoPassword();
            string hashedPassword = cryptoFunctions.Hash(password);

            //Generate new iban (id)
            string newIban = GenerateIBAN();

            // Create a SQL query
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "insert into USERS (iban, type, email, password, money) values (@iban, @type, @email, @password, @money)";

            // Add parameters to query
            query.Parameters.AddWithValue("@iban", newIban);
            query.Parameters.AddWithValue("@type", type);
            query.Parameters.AddWithValue("@email", email);
            query.Parameters.AddWithValue("@password", hashedPassword);
            query.Parameters.AddWithValue("@money", money);


            bool result;
            try
            {
                // Execute the SQL command
                if(query.ExecuteNonQuery() == 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch(MySqlException)
            {
                throw new UserAlreadyExistsException();
            }
            

            return result;
        }


        /// <summary>
        /// Check a user's login with password in the database
        /// </summary>
        /// <param name="email">User's email</param>
        /// <param name="password">User's password</param>
        /// <returns>true if passwords matchs</returns>
        public bool VerifyUser(string email, string password)
        {
            // Create a SQL query
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select password from USERS where email = (@email) and active = 1";

            // Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            string hashedPassword;
            try
            {
                //Get hashed and salted password from the database
                DbDataReader reader = query.ExecuteReader();

                reader.Read();
                hashedPassword = reader.GetString(0);
                reader.Close();
            }
            catch(MySqlException)
            {
                throw new UserDoesNotExistsException();
            }
            

            //Verify if passwords matchs
            CryptoPassword cryptoFunctions = new CryptoPassword();
            bool correctPassword = cryptoFunctions.Verify(password, hashedPassword);

            return correctPassword;
        }


        /// <summary>
        /// Get all user's informations and transactions from his email
        /// </summary>
        /// <param name="email">User's email</param>
        /// <returns>Return user's informations</returns>
        public User GetUser(string email)
        {
            #region Account type management
            // Create a command object
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select iban, type+0 as type, email, money from USERS where email = (@email)";

            //Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            //Get user's money from the database
            DbDataReader reader = query.ExecuteReader();
            reader.Read();

            User user;
            if ((User.AccountType)reader.GetInt32(1) == User.AccountType.Enterprise)
            {
                user = new EnterpriseUser(reader.GetString(0), reader.GetString(2), reader.GetDouble(3));
            }
            else if ((User.AccountType)reader.GetInt32(1) == User.AccountType.Admin)
            {
                user = new AdminUser(reader.GetString(0), reader.GetString(2));
            }
            else
            {
                user = new PublicUser(reader.GetString(0), reader.GetString(2), reader.GetDouble(3));
            }

            reader.Close();
            #endregion


            #region Transactions management
            // Create a command object
            query = connection.CreateCommand();
            if (user.GetType() == typeof(AdminUser))
            {
                query.CommandText = @"select TRANSACTIONS.date, TRANSACTIONS.amount, TRANSACTIONS.reason, 
                                    USER_RECEIVER.email, USER_RECEIVER.iban, USER_SENDER.email, USER_SENDER.iban from TRANSACTIONS
                                    left join USERS as USER_RECEIVER on USER_RECEIVER.id = TRANSACTIONS.idReceiver
                                    left join USERS as USER_SENDER on USER_SENDER.id = TRANSACTIONS.idSender
                                    order by TRANSACTIONS.date desc";
            }
            else
            {
                query.CommandText = @"select TRANSACTIONS.date, TRANSACTIONS.amount, TRANSACTIONS.reason, 
                                    USER_RECEIVER.email, USER_RECEIVER.iban, USER_SENDER.email, USER_SENDER.iban from TRANSACTIONS
                                    left join USERS as USER_RECEIVER on USER_RECEIVER.id = TRANSACTIONS.idReceiver
                                    left join USERS as USER_SENDER on USER_SENDER.id = TRANSACTIONS.idSender
                                    where USER_RECEIVER.email = (@concerned1) OR USER_SENDER.email  = (@concerned2)
                                    order by TRANSACTIONS.date desc";

                //Add parameters to query
                query.Parameters.AddWithValue("@concerned1", email);
                query.Parameters.AddWithValue("@concerned2", email);
            }

            //Get user's money from the database
            reader = query.ExecuteReader();
            
            if (reader.HasRows)
            {
                //Add each transactions linked to the user
                while (reader.Read())
                {
                    Transaction newTransaction = new Transaction(
                        reader.GetDateTime(0).ToString(), 
                        reader.GetDouble(1), 
                        reader.GetString(2), 
                        reader.GetString(3), 
                        reader.GetString(4), 
                        reader.GetString(5), 
                        reader.GetString(6));
                    ((PublicUser)user).Transactions.Add(newTransaction);
                }
            }
            reader.Close();
            #endregion


            #region Lists management (only enterprise and admin users)
            if(user.GetType() == typeof(EnterpriseUser) || user.GetType() == typeof(AdminUser))
            {
                // Create a command object
                query = connection.CreateCommand();
                if (user.GetType() == typeof(AdminUser))
                {
                    query.CommandText = @"select lists.name, COALESCE(USER_INSIDE.iban,''), COALESCE(USER_INSIDE.email,'') from lists
                                        left join users_lists on users_lists.idList = lists.id
                                        left join users as LIST_OWNER on lists.idUser = LIST_OWNER.id
                                        left join users as USER_INSIDE on users_lists.idUser = USER_INSIDE.id
                                        order by lists.name asc";
                }
                else
                {
                    query.CommandText = @"select lists.name, COALESCE(USER_INSIDE.iban,''), COALESCE(USER_INSIDE.email,'') from lists
                                        left join users_lists on users_lists.idList = lists.id
                                        left join users as LIST_OWNER on lists.idUser = LIST_OWNER.id
                                        left join users as USER_INSIDE on users_lists.idUser = USER_INSIDE.id
                                        where LIST_OWNER.email = (@owner)
                                        order by lists.name asc";

                    //Add parameters to query
                    query.Parameters.AddWithValue("@owner", email);
                }
         
                //Get user's money from the database
                reader = query.ExecuteReader();

                bool endFlag = false;
                if (reader.HasRows)
                {
                    reader.Read();

                    while (!endFlag)
                    {
                        UsersList usersList = new UsersList(reader.GetString(0));

                        if (reader.GetString(1) != "" && reader.GetString(2) != "")
                        {
                            usersList.Users.Add(new User(reader.GetString(1), reader.GetString(2)));

                            while (true)
                            {
                                if (!reader.Read())
                                {
                                    endFlag = true;
                                    break;
                                }

                                if (reader.GetString(0) == usersList.Name)
                                {
                                    usersList.Users.Add(new User(reader.GetString(1), reader.GetString(2)));
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (!reader.Read())
                            {
                                endFlag = true;
                            }
                        }
                        ((EnterpriseUser)user).Lists.Add(usersList);
                    }
                }
                reader.Close();
            }
            #endregion

            return user;
        }


        /// <summary>
        /// Return user's from iban
        /// </summary>
        /// <returns>Email address coresponding to iban</returns>
        public string EmailFromIban(string iban)
        {
            // Create a command object
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select email from USERS where iban = (@iban)";

            //Add parameters to query
            query.Parameters.AddWithValue("@iban", iban);

            //Get user's email from iban
            DbDataReader reader = query.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                return reader.GetString(0);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// Move money from one account 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="reason"></param>
        /// <param name="senderIban"></param>
        /// <param name="receiverIban"></param>
        /// <returns>true for success, false for an error</returns>
        public bool Transact(double amount, string reason, string senderIban, string receiverIban)
        {
            DateTime time = DateTime.Now;
            string nowTime = time.ToString("yyyy-MM-dd HH:mm:ss");

            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"insert into TRANSACTIONS (date, amount, reason, idSender, idReceiver) 
                                values ((@date), (@amount), (@reason), 
                                (select USERS.id from USERS where iban = (@senderIban)),
                                (select USERS.id from USERS where iban = (@receiverIban)))";

            // Add parameters to query
            query.Parameters.AddWithValue("@date", nowTime);
            query.Parameters.AddWithValue("@amount", amount);
            query.Parameters.AddWithValue("@reason", reason);
            query.Parameters.AddWithValue("@senderIban", senderIban);
            query.Parameters.AddWithValue("@receiverIban", receiverIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }

            query = connection.CreateCommand();
            query.CommandText = @"update USERS set money = money + (@amount) where iban = (@receiverIban)";

            // Add parameters to query
            query.Parameters.AddWithValue("@amount", amount);
            query.Parameters.AddWithValue("@receiverIban", receiverIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }


            query = connection.CreateCommand();
            query.CommandText = @"update USERS set money = money - (@amount) where iban = (@senderIban)";

            // Add parameters to query
            query.Parameters.AddWithValue("@amount", amount);
            query.Parameters.AddWithValue("@senderIban", senderIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }



            return true;

        }


        /// <summary>
        /// Create a new empty list
        /// </summary>
        /// <param name="newName">New list name</param>
        /// <param name="creatorIban">Iban of the user who created the list</param>
        /// <returns>true for success, false for an error</returns>
        public bool CreateList(string newName, string creatorIban)
        {
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"insert into LISTS (name, idUser) 
                                values ((@name), 
                                (select USERS.id from USERS where iban = (@creatorIban)))";

            // Add parameters to query
            //List name : create a list name unique per user
            query.Parameters.AddWithValue("@name", $"{creatorIban}_{newName}");
            query.Parameters.AddWithValue("@creatorIban", creatorIban);

            // Execute the SQL command and check error
            try
            {
                if (query.ExecuteNonQuery() != 1)
                {
                    return false;
                }
            }
            catch(MySqlException)
            {
                throw new ListAlreadyExists();
            }
            

            return true;
        }


        /// <summary>
        /// Delete a list
        /// </summary>
        /// <param name="listName">Unique list name</param>
        /// <returns>true for success, false for an error</returns>
        public bool DeleteList(string listName)
        {
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"delete from LISTS
                                where name = (@listName)";

            // Add parameters to query
            query.Parameters.AddWithValue("@listName", listName);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Add a user in a list
        /// </summary>
        /// <param name="listName">List where user need to be added</param>
        /// <param name="userIban">Iban of the user who need to be added</param>
        /// <returns>true for success, false for an error</returns>
        public bool AddUserList(string listName, string userIban)
        {
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"insert into USERS_LISTS (idList, idUser)
                                values (
                                (select LISTS.id from LISTS where name = (@listName)),
                                (select USERS.id from USERS where iban = (@userIban)))";

            // Add parameters to query
            query.Parameters.AddWithValue("@listName", listName);
            query.Parameters.AddWithValue("@userIban", userIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Delete a user from a list
        /// </summary>
        /// <param name="listName">List where user need to be deleted</param>
        /// <param name="userIban">Iban of the user who need to be deleted</param>
        /// <returns>true for success, false for an error</returns>
        public bool DeleteUserList(string listName, string userIban)
        {
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"delete from USERS_LISTS 
                                where USERS_LISTS.idList = (select id from LISTS where name = (@listName))
                                AND   USERS_LISTS.idUser = (select id from USERS where iban = (@userIban));";

            // Add parameters to query
            query.Parameters.AddWithValue("@listName", listName);
            query.Parameters.AddWithValue("@userIban", userIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Verify a user password then change it with a new one
        /// </summary>
        /// <param name="userEmail">User who need to change his password</param>
        /// <param name="newPassword">Iban of the user who need to be deleted</param>
        /// <returns>true for success, false for an error</returns>
        public bool ChangePassword(string userEmail, string newPassword)
        {
            //Hash and salt password
            CryptoPassword cryptoFunctions = new CryptoPassword();
            string hashedPassword = cryptoFunctions.Hash(newPassword);

            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"update USERS set password = (@newHashPassword)
                                where email = (@userEmail);";

            // Add parameters to query
            query.Parameters.AddWithValue("@newHashPassword", hashedPassword);
            query.Parameters.AddWithValue("@userEmail", userEmail);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Disable an account
        /// </summary>
        /// <param name="userEmail">User's email of the account who need to be disabled</param>
        /// <returns>true for success, false for an error</returns>
        public bool DisableAccount(string userEmail)
        {
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = @"update USERS set active = 0
                                where email = (@userEmail);";

            // Add parameters to query
            query.Parameters.AddWithValue("@userEmail", userEmail);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        /*
        /// <summary>
        /// Delete a user from the database
        /// </summary>
        /// <param name="email">User's email to delete</param>
        /// <returns>1 if success, 0 for failure</returns>
        public int DeleteUser(string email)
        {
            // Create a SQL command
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "delete from USERS where email = (@email)";

            // Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            int result = 0;
            // Execute the SQL command
            result = query.ExecuteNonQuery();

            return result;
        }
        */

        /*
        /// <summary>
        /// Get the user's money amount from his email
        /// </summary>
        /// <param name="email">User's email</param>
        /// <returns>Return user's money</returns>
        public double GetUserMoney(string email)
        {
            // Create a command object
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select money from USERS where email = (@email)";

            //Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            //Get user's money from the database
            DbDataReader reader = query.ExecuteReader();
            reader.Read();

            double result = reader.GetDouble(0);
            reader.Close();

            return result;
        }
        */


        /// <summary>
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }
    }
}
