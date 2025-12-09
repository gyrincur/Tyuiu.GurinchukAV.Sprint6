using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GurinchukAV.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = (stopValue - startValue) + 1;
            array = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Sin(i) - 3 + i) == 0)
                    array[count] = 0;
                else
                    array[count] = Math.Round(((3 * i - 1.5) / (Math.Sin(i) - 3 + i)) + 2, 2);
                count++;
            }
            return array;
        }
    }
}