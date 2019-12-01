using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestJson
    {
        [TestMethod]
        public void TestInsertNormalData()
        {
            JsonData fileData = new JsonData();
            fileData.LoginWindowLocation = new System.Drawing.Point(80,90);

            JsonManagement writer = new JsonManagement();
            writer.InsertData(fileData);
        }

        [TestMethod]
        public void TestExtractNormalData()
        {
            JsonData excepted = new JsonData();
            excepted.LoginWindowLocation = new System.Drawing.Point(80, 90);

            JsonData fileData = new JsonData();

            JsonManagement reader = new JsonManagement();
            fileData = reader.ExtractData();

            Assert.AreEqual(excepted.LoginWindowLocation, fileData.LoginWindowLocation);
        }
    }
}
