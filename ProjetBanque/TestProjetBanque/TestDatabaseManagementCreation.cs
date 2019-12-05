using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using MySql.Data.MySqlClient;

using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestDatabaseManagementCreation
    {
        [TestMethod]
        public void TestNormalInsert()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.AddUser("jerome.jaquemet@gmail.com", "passing", "Public", 30000);

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        [ExpectedException(typeof(UserAlreadyExistsException))]
        public void TestInsertExistingUser()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.AddUser("jerome.jaquemet@gmail.com", "passing", "Public");

            //close connection
            connDB.CloseConnection();
        }

        [TestMethod]
        [ExpectedException(typeof(WrongEmailFormatException))]
        public void TestInsertWrongEmail()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.AddUser("jerome", "passing", "Public");

            //close connection
            connDB.CloseConnection();
        }
        
        [TestMethod]
        //no longer delete right, raise exception
        [ExpectedException(typeof(MySqlException))]
        public void TestDeletingExistingUser()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            int success = connDB.DeleteUser("jerome.jaquemet@gmail.com");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(1, success);
        }

        [TestMethod]
        //no longer delete right, raise exception
        [ExpectedException(typeof(MySqlException))]
        public void TestDeletingNonExistingUser()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            int success = connDB.DeleteUser("jean.claude@gmail.com");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(0, success);
        }
    }
}
