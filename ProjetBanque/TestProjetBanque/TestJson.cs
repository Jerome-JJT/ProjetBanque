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
            fileData.WindowPosition = new System.Drawing.Point(80,90);
            fileData.WindowSize = new System.Drawing.Size(400,500);

            JsonManagement writer = new JsonManagement();
            writer.InsertData("bankProfile.json", fileData);

            //Assert.AreEqual(0, fileData.windowPosition[0]);
        }

        [TestMethod]
        public void TestExtractNormalData()
        {
            JsonData excepted = new JsonData();
            excepted.WindowPosition = new System.Drawing.Point(80, 90);
            excepted.WindowSize = new System.Drawing.Size(400, 500);

            JsonData fileData = new JsonData();

            JsonManagement reader = new JsonManagement();
            fileData = reader.ExtractData("bankProfile.json");

            Assert.AreEqual(excepted.WindowPosition, fileData.WindowPosition);
            Assert.AreEqual(excepted.WindowSize, fileData.WindowSize);
        }
    }
}
