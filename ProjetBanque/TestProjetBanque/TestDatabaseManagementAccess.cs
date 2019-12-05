using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using MySql.Data.MySqlClient;

using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestDatabaseManagementAccess
    {
        [TestMethod]
        public void TestNormalLogin()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.VerifyUser("jerome.jaquemet@gmail.com", "passing");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestWrongLogin()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.VerifyUser("jerome.jaquemet@gmail.com", "passnot");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(false, success);
        }

        [TestMethod]
        [ExpectedException(typeof(UserDoesNotExistsException))]
        public void TestNonExitingLogin()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.VerifyUser("jean.claude@gmail.com", "passnot");

            //close connection
            connDB.CloseConnection();
        }


        [TestMethod]
        public void TestGetUserMoney()
        {
            DatabaseManagement connDB = new DatabaseManagement();
            connDB.OpenConnection();

            //get a specific users money
            double result = connDB.GetUserMoney("jerome.jaquemet@gmail.com");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(30000, result);
        }
    }
}
