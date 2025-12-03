using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GurinchukAV.Sprint6.Task0.V2.Lib
{
    public class DataService : ISprint6Task0V2
    {
        public double Calculate(int x)
        {
            double res = Math.Round(((2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2))), 3);
            return res;
        }
    }
}