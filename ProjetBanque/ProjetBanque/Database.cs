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
        /// add a player in the table "players"
        /// </summary>
        /// <param name="pseudo"></param>
        public void AddPlayer(string pseudo)
        {
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = "insert into players (pseudo) values (@name)";

            // use of the pseudo string, parameter of the method AddPlayer
            cmd.Parameters.AddWithValue("@name", pseudo);

            // Execute the SQL command
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// get the name of the player according to his id
        /// </summary>
        /// <param name="id">id of the player</param>
        /// <returns></returns>
        public int GetUserMoney(int id)
        {
            int money = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select money from users where id = " + id;

            DbDataReader reader = cmd.ExecuteReader();

            reader.Read();



            int result = reader.GetInt32(0);

            /*if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    //if a field can be null, we check if the result is not null before getting the value
                    //if (!reader.IsDBNull(2))
                    //{
                    //    telContact = reader.GetString(2);
                    //}

                }
                return name;
            }*/

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
