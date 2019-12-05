using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetBanque;

namespace TestProjetBanque
{
    [TestClass]
    public class TestJson
    {
        [TestMethod]
        public void TestCreateDirectory()
        {
            JsonManagement creater = new JsonManagement();
            string path = $"{Environment.GetEnvironmentVariable("appdata")}/BankProfile";

            Assert.IsTrue(Directory.Exists(path));
            Assert.IsTrue(File.Exists($"{path}/bankProfile.json"));
        }

        [TestMethod]
        public void TestInsertNormalProfile()
        {
            JsonData fileData = new JsonData();
            fileData.LoginWindowLocation = new System.Drawing.Point(80,90);

            JsonManagement writer = new JsonManagement();
            writer.InsertData(fileData);
        }

        [TestMethod]
        public void TestExtractNormalProfile()
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
