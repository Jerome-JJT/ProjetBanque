using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using MySql.Data.MySqlClient;

using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestDatabase
    {
        [TestMethod]
        public void TestNormalInsert()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            int success = connDB.AddUser("jerome@jaquemet.gmail.com", "passing", "Public", 30000);

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(1, success);
        }

        [TestMethod]
        [ExpectedException(typeof(MySqlException))]
        public void TestInsertExistingUser()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            int success = connDB.AddUser("jerome@jaquemet.gmail.com", "passing", "Public");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(0, success);
        }

        [TestMethod]
        public void TestNormalLogin()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.VerifyUser("jerome@jaquemet.gmail.com", "passing");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestWrongLogin()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.VerifyUser("jerome@jaquemet.gmail.com", "passnot");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(false, success);
        }

        [TestMethod]
        [ExpectedException(typeof(MySqlException))]
        public void TestNonExitingLogin()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            bool success = connDB.VerifyUser("jean@claude.gmail.com", "passnot");

            //close connection
            connDB.CloseConnection();
        }


        [TestMethod]
        public void TestGetUserMoney()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //get a specific users money
            int result = connDB.GetUserMoney(1);

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(30000, result);
        }


        [TestMethod]
        public void TestDeletingExistingUser()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            int success = connDB.DeleteUser("jerome@jaquemet.gmail.com");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(1, success);
        }

        [TestMethod]
        public void TestDeletingNonExistingUser()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            int success = connDB.DeleteUser("jean@claude.gmail.com");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(0, success);
        }
    }
}
