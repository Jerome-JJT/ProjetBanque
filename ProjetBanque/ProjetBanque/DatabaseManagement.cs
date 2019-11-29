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
        /// Add a user in the database with 0 money
        /// </summary>
        /// <param name="email">User's email, will be verified with regex</param>
        /// <param name="password">User's password, will be hashed and salted</param>
        /// <param name="type">Account type, "Public" or "Enterprise", "Admin" can't be added here</param>
        /// <returns>1 if success, 0 for an error
        public int AddUser(string email, string password, string type)
        {
            return AddUser(email, password, type, 0);
        }

        /// <summary>
        /// Add a user in the database with a certain ammount of money
        /// </summary>
        /// <param name="email">User's email, will be verified with regex</param>
        /// <param name="password">User's password, will be hashed and salted</param>
        /// <param name="type">Account type, "Public" or "Enterprise", "Admin" can't be added here</param>
        /// <param name="money">Base money for the account</param>
        /// <returns>1 if success, 0 for an error
        public int AddUser(string email, string password, string type, double money)
        {
            if (!(new List<string> { "Public", "Entreprise" }).Contains(type))
            {
                throw new WrongAccountTypeException();
            }

            try
            {
                MailAddress addr = new MailAddress(email);

                if (!(addr.Address == email))
                {
                    throw new WrongEmailFormatException();
                }
            }
            catch (FormatException)
            {
                throw new WrongEmailFormatException();
            }
            catch (ArgumentException)
            {
                throw new WrongEmailFormatException();
            }


            //Hash and salt password
            CryptoPassword cryptoFunctions = new CryptoPassword();
            string hashedPassword = cryptoFunctions.Hash(password);

            // Create a SQL query
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "insert into users (type, email, password, money) values (@type, @email, @password, @money)";

            // Add parameters to query
            query.Parameters.AddWithValue("@type", type);
            query.Parameters.AddWithValue("@email", email);
            query.Parameters.AddWithValue("@password", hashedPassword);
            query.Parameters.AddWithValue("@money", money);


            int result;
            try
            {
                // Execute the SQL command
                result = query.ExecuteNonQuery();
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
        /// <returns>true if passwords matchs
        public bool VerifyUser(string email, string password)
        {
            // Create a SQL query
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select (password) from users where email = (@email)";

            // Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            string hashedPassword;
            try
            {
                //Get hashed and salted password from the database
                DbDataReader reader = query.ExecuteReader();
                reader.Read();
                hashedPassword = reader.GetString(0);
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
        /// Delete a user from the database
        /// </summary>
        /// <param name="email">User's email to delete</param>
        /// <returns>1 if success, 0 for failure
        public int DeleteUser(string email)
        {
            // Create a SQL command
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "delete from users where email = (@email)";

            // Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            int result = 0;
            // Execute the SQL command
            result = query.ExecuteNonQuery();

            return result;
        }



        /// <summary>
        /// Get the user's money amount from his email
        /// </summary>
        /// <param name="email">User's email</param>
        /// <returns>Return user's money</returns>
        public double GetUserMoney(string email)
        {
            // Create a command object
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select money from users where email = (@email)";

            // Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            //Get user's money from the database
            DbDataReader reader = query.ExecuteReader();

            reader.Read();

            double result = reader.GetDouble(0);

            return result;
        }


        /// <summary>
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }
    }
}
