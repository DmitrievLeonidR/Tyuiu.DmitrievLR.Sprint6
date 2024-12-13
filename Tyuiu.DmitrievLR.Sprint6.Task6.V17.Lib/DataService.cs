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
                // Read all lines from the file
                string[] lines = File.ReadAllLines(path);

                // Loop through each line
                foreach (string line in lines)
                {
                    // Split the line into words
                    string[] words = line.Split(' ');

                    // Check if there are at least three words in the line
                    if (words.Length >= 3)
                    {
                        // Add the third word to the result string
                        result += words[2] + " ";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            // Return the result string
            return result;
        }
    }
}
