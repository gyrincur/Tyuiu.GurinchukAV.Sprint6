using Tyuiu.GurinchukAV.Sprint6.Task1.V20.Lib;
namespace Tyuiu.GurinchukAV.Sprint6.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);

            double[] wait = new double[11];
            wait[0] = -27.22;
            wait[1] = -22.25;
            wait[2] = -16.66;
            wait[3] = -11.04;
            wait[4] = -6.13;
            wait[5] = -3;
            wait[6] = 4.84;
            wait[7] = 8.86;
            wait[8] = 14.43;
            wait[9] = 20.18;
            wait[10] = 25.24;
            CollectionAssert.AreEqual(res, wait);
            
        }
    }
}