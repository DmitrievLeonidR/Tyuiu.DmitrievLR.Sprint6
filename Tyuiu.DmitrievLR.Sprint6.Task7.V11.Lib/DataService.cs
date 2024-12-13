using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Get the dimensions of the matrix
            int rows = lines.Length;
            int cols = lines[0].Split(',').Length;

            // Create a 2D array to store the matrix
            int[,] matrix = new int[rows, cols];

            // Parse the CSV data into the matrix
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Return the matrix
            return matrix;
        }
    }
}
