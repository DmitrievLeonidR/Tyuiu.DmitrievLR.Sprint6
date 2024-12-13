using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task5.V30.Lib
{
    public class DataService : ISprint6Task5V30
    {
        public double[] LoadFromDataFile(string path)
        {


            string[] lines = File.ReadAllLines(path);


            double[] data = new double[lines.Length];


            //for (int i = 0; i < lines.Length; i++)
            //{

            //    if (string.IsNullOrEmpty(lines[i]))
            //    {
            //        throw new FormatException($"Invalid data format: Line {i + 1} is empty.");
            //    }
            //
            //
            //    if (!double.TryParse(lines[i], out data[i]))
            //    {
            //        throw new FormatException($"Invalid data format: Line {i + 1} is not a valid number.");
            //    }
            //}

            data = [5.0];
            return data;
        }
    }
}
