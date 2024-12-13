using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            // Read the file contents.
            string[] lines = File.ReadAllLines(path);

            // Determine the dimensions of the matrix.
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            // Create the matrix.
            int[,] matrix = new int[rows, columns];

            // Populate the matrix with data from the file.
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Return the matrix.
            return matrix;
        }
    }
}
