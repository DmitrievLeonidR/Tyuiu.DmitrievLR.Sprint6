using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task6.V17.Lib
{
    public class DataService : ISprint6Task6V17
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            try
            {

                string[] lines = File.ReadAllLines(path);


                foreach (string line in lines)
                {

                    string[] words = line.Split(' ');

                    if (words.Length >= 3)
                    {

                        result += words[2] + " ";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            result = result.Substring(0, result.Length - 1);


            return result;
        }
    }
}
