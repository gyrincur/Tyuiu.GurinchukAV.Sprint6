using System.IO;
using Tyuiu.GurinchukAV.Sprint6.Task7.V28.Lib;
namespace Tyuiu.GurinchukAV.Sprint6.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\настя\source\repos\Tyuiu.GurinchukAV.Sprint6\Tyuiu.GurinchukAV.Sprint6.Task7.V28\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}