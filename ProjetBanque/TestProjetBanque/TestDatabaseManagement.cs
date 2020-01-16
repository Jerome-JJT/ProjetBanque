using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using MySql.Data.MySqlClient;

using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestDatabaseManagement
    {
        DatabaseManagement connDB;

        [TestInitialize]
        public void TestInit()
        {
            connDB = new DatabaseManagement();

            connDB.OpenConnection();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            connDB.CloseConnection();
        }

        [TestMethod]
        [Priority(0)]
        public void TestInsertNormalUser()
        {
            //add a user
            bool success = connDB.AddUser("jerome.jaquemet@gmail.com", "passing", "Public", 30000);

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        [Priority(1)]
        [ExpectedException(typeof(UserAlreadyExistsException))]
        public void TestInsertExistingUser()
        {
            //add a user
            bool success = connDB.AddUser("jerome.jaquemet@gmail.com", "passing", "Public");
        }

        [TestMethod]
        [Priority(1)]
        [ExpectedException(typeof(WrongEmailFormatException))]
        public void TestInsertWrongEmail()
        {
            //add a user
            bool success = connDB.AddUser("jerome", "passing", "Public");
        }

        [TestMethod]
        [Priority(1)]
        public void TestNormalLogin()
        {
            //add a user
            bool success = connDB.VerifyUser("jerome.jaquemet@gmail.com", "passing");

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        [Priority(1)]
        public void TestWrongLogin()
        {
            //add a user
            bool success = connDB.VerifyUser("jerome.jaquemet@gmail.com", "passnot");

            Assert.AreEqual(false, success);
        }

        [TestMethod]
        [Priority(1)]
        [ExpectedException(typeof(UserDoesNotExistsException))]
        public void TestNonExitingLogin()
        {
            //add a user
            bool success = connDB.VerifyUser("jean.claude@gmail.com", "passnot");
        }
    }
}
