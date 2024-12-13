using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task3.V4.Lib
{
    public class DataService : ISprint6Task3V4
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[1, i] % 2 == 0)
                {
                    matrix[1, i] = 0;
                }
            }
           
            return matrix;
        }
    }
}
