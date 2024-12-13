using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            // Read the file lines.
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            // Determine the dimensions of the matrix.
            int rows = lines.Count;
            int cols = lines[0].Split(',').Length;

            // Create the matrix.
            int[,] matrix = new int[rows, cols];

            // Populate the matrix.
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j]);
                }
            }

            // Return the matrix.
            return matrix;
        }
    }
}
