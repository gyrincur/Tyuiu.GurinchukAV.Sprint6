using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GurinchukAV.Sprint6.Task3.V14.Lib
{
    public class DataService : ISprint6Task3V14
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);


            for (int j = 0; j < columns; j++)
            {
                if (matrix[1, j] % 2 == 0)
                    matrix[1, j] = 0;
            }
            return matrix;


        }
    }
}