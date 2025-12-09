using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GurinchukAV.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resultArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 3 * x + 1.2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    resultArray[count] = 0;
                }
                else
                {
                    double fraction = (2 * Math.Sin(x)) / denominator;
                    double result = fraction + Math.Cos(x) - 7 * x * 2;
                    resultArray[count] = Math.Round(result, 2);
                }
                count++;
            }
            return resultArray;
        }
    }
}