using System.IO;
using Tyuiu.GurinchukAV.Sprint6.Task5.V26.Lib;
namespace Tyuiu.GurinchukAV.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\Sprint5Task5\Sprint5Task5\InPutDataFileTask5V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}