using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task2.V5.Lib
{
    public class DataService : ISprint6Task2V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            // Calculate the number of values in the array.
            int count = stopValue - startValue + 1;

            // Create an array to store the function values.
            double[] functionValues = new double[count];

            // Iterate through the range and calculate the function value for each x.
            for (int i = 0; i < count; i++)
            {
                int x = startValue + i;
                functionValues[i] = CalculateFunctionValue(x);
            }

            return functionValues;
        }

        private double CalculateFunctionValue(int x)
        {
            // Handle division by zero.
            if (Math.Cos(x) - 2 * x == 0)
            {
                return 0;
            }

            // Calculate the function value.
            double value = (2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6;
            return Math.Round(value, 2);
        }

    }
}
