using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestDatabase
    {
        [TestMethod]
        public void TestNormalSelect()
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
        public void TestNormalInsert()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //add a user
            int success = connDB.AddUser("jerome@jaquemet.gmail.com", "passing", "Public");

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(1, success);
        }

        [TestMethod]
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
    }
}
