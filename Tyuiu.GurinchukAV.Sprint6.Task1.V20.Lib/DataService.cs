using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GurinchukAV.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] value;
            int len = (stopValue - startValue) + 1;
            value = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x), 2);
                value[c] = y;
                c++;
            }
            return value;
        }
    }
}