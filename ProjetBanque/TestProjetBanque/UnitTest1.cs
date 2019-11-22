using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestProjetBanque
    {
        [TestMethod]
        public void TestNormalDbConnexion()
        {
            Database connDB = new Database();
            connDB.OpenConnection();

            //get a specific player
            int name = connDB.GetUserMoney(1);

            //close connection
            connDB.CloseConnection();

            Assert.AreEqual(30000, name);
        }
    }
}
