using Tyuiu.GurinchukAV.Sprint6.Task2.V15.Lib;
namespace Tyuiu.GurinchukAV.Sprint6.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = {
                67.42, 55.67, 44.32, 33.49, 23.19,
                13.41, 4.14, -4.64, -12.93, -20.75, -28.12
            };

            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void DivisionByZeroCheck()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(0, 0);

            Assert.AreNotEqual(0, res[0]);
        }
    }
}