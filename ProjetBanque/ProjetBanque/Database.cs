using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ProjetBanque
{
    public class Database
    {
        private MySqlConnection connection;

        public Database()
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
            string connectionString = "SERVER=127.0.0.1; DATABASE=Banking; UID=root; PASSWORD=12345678";
            connection = new MySqlConnection(connectionString);
        }


        /// <summary>
        /// Open connection to the database
        /// </summary>
        public void OpenConnection()
        {
            connection.Open();
        }


        /// <summary>
        /// Add a user in the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns>1 if success, 0 for duplicate entry or -1 for unknown error
        public int AddUser(string email, string password, string type)
        {
            if (!(new List<string> { "Public", "Entreprise" }).Contains(type))
            {
                throw new Exception("Wrong account type");
            }

            CryptoPassword cryptoFunctions = new CryptoPassword();
            string hashedPassword = cryptoFunctions.Hash(password);


            // Create a SQL command
            MySqlCommand query = connection.CreateCommand();

            // SQL request
            query.CommandText = "insert into users (type, email, password) values (@type, @email, @password)";

            // Add parameters to query
            query.Parameters.AddWithValue("@type", type);
            query.Parameters.AddWithValue("@email", email);
            query.Parameters.AddWithValue("@password", hashedPassword);

            int result = 0;

            // Execute the SQL command
            result = query.ExecuteNonQuery();

            return result;
        }

        /// <summary>
        /// Add a user in the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns>1 if success, 0 for duplicate entry or -1 for unknown error
        public int AddUser(string email, string password, string type, int money)
        {
            if (!(new List<string> { "Public", "Entreprise" }).Contains(type))
            {
                throw new Exception("Wrong account type");
            }

            CryptoPassword cryptoFunctions = new CryptoPassword();
            string hashedPassword = cryptoFunctions.Hash(password);


            // Create a SQL command
            MySqlCommand query = connection.CreateCommand();

            // SQL request
            query.CommandText = "insert into users (type, email, password, money) values (@type, @email, @password, @money)";

            // Add parameters to query
            query.Parameters.AddWithValue("@type", type);
            query.Parameters.AddWithValue("@email", email);
            query.Parameters.AddWithValue("@password", hashedPassword);
            query.Parameters.AddWithValue("@money", money);

            int result = 0;

            // Execute the SQL command
            result = query.ExecuteNonQuery();

            return result;
        }

        /// <summary>
        /// Verify a user with password in the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true if password success
        public bool VerifyUser(string email, string password)
        {
            // Create a SQL command
            MySqlCommand query = connection.CreateCommand();

            // SQL request
            query.CommandText = "select (password) from users where email = (@email)";
            query.Parameters.AddWithValue("@email", email);

            DbDataReader reader = query.ExecuteReader();

            reader.Read();

            string hashedPassword = reader.GetString(0);


            CryptoPassword cryptoFunctions = new CryptoPassword();
            bool correctPassword = cryptoFunctions.Verify(password, hashedPassword);

            return correctPassword;
        }

        /// <summary>
        /// Add a user in the database
        /// </summary>
        /// <param name="email"></param>
        /// <returns>1 if success, 0 for duplicate entry or -1 for unknown error
        public int DeleteUser(string email)
        {
            // Create a SQL command
            MySqlCommand query = connection.CreateCommand();

            // SQL request
            query.CommandText = "delete from users where email = (@email)";

            // Add parameters to query
            query.Parameters.AddWithValue("@email", email);

            int result = 0;

            // Execute the SQL command
            result = query.ExecuteNonQuery();

            return result;
        }



        /// <summary>
        /// get the name of the player according to his id
        /// </summary>
        /// <param name="id">id of the player</param>
        /// <returns>Return user's money</returns>
        public int GetUserMoney(int email)
        {
            // Create a command object
            MySqlCommand query = connection.CreateCommand();

            query.CommandText = "select money from users where email = (@email)";
            query.Parameters.AddWithValue("@email", email);

            DbDataReader reader = query.ExecuteReader();

            reader.Read();

            int result = reader.GetInt32(0);

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
