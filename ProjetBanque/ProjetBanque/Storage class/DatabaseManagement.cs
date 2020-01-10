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
            query.CommandText = "select password from USERS where email = (@email)";

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
            //else if ((User.AccountType)reader.GetInt32(1) == User.AccountType.Public)
            else
            {
                user = new User(reader.GetString(0), reader.GetString(2), reader.GetDouble(3));
            }
            /*else if ((User.AccountType)reader.GetInt32(1) == User.AccountType.Admin)
            {
                new AdminUser(reader.GetString(0), reader.GetString(2), reader.GetDouble(3));
            }*/

            reader.Close();



            // Create a command object
            query = connection.CreateCommand();
            query.CommandText = @"select TRANSACTIONS.date, TRANSACTIONS.amount, TRANSACTIONS.reason, 
                                USER_RECEIVER.email, USER_RECEIVER.iban, USER_SENDER.email, USER_SENDER.iban from TRANSACTIONS
                                left join USERS as USER_RECEIVER on USER_RECEIVER.id = TRANSACTIONS.idReceiver
                                left join USERS as USER_SENDER on USER_SENDER.id = TRANSACTIONS.idSender
                                where USER_RECEIVER.email = (@concerned1) OR USER_SENDER.email  = (@concerned2)";

            //Add parameters to query
            query.Parameters.AddWithValue("@concerned1", email);
            query.Parameters.AddWithValue("@concerned2", email);

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
                    user.Transactions.Add(newTransaction);
                }
            }
            reader.Close();


            if(user.GetType() == typeof(EnterpriseUser))
            {
                // Create a command object
                query = connection.CreateCommand();
                query.CommandText = @"select TRANSACTIONS.date, TRANSACTIONS.amount, TRANSACTIONS.reason, 
                                USER_RECEIVER.email, USER_RECEIVER.iban, USER_SENDER.email, USER_SENDER.iban from TRANSACTIONS
                                left join USERS as USER_RECEIVER on USER_RECEIVER.id = TRANSACTIONS.idReceiver
                                left join USERS as USER_SENDER on USER_SENDER.id = TRANSACTIONS.idSender
                                where USER_RECEIVER.email = (@concerned1) OR USER_SENDER.email  = (@concerned2)
                                order by TRANSACTIONS.date desc";

                //Add parameters to query
                query.Parameters.AddWithValue("@concerned1", email);
                query.Parameters.AddWithValue("@concerned2", email);

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
                        user.Transactions.Add(newTransaction);
                    }
                }
                reader.Close();
            }
            

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
        /// <returns></returns>
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

            bool result;

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                result = false;
            }



            query = connection.CreateCommand();
            query.CommandText = @"UPDATE USERS SET money = money + (@amount) WHERE iban = (@receiverIban)";

            // Add parameters to query
            query.Parameters.AddWithValue("@amount", amount);
            query.Parameters.AddWithValue("@receiverIban", receiverIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                result = false;
            }


            query = connection.CreateCommand();
            query.CommandText = @"UPDATE USERS SET money = money - (@amount) WHERE iban = (@senderIban)";

            // Add parameters to query
            query.Parameters.AddWithValue("@amount", amount);
            query.Parameters.AddWithValue("@senderIban", senderIban);

            // Execute the SQL command and check error
            if (query.ExecuteNonQuery() != 1)
            {
                result = false;
            }



            return true;

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
