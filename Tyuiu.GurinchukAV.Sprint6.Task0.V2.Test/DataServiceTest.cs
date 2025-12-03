using Tyuiu.GurinchukAV.Sprint6.Task0.V2.Lib;
namespace Tyuiu.GurinchukAV.Sprint6.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 6.425;
            Assert.AreEqual(wait, res);
        }
    }
}