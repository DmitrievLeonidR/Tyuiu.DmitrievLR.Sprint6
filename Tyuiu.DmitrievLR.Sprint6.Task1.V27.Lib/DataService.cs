using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task1.V27.Lib
{
    public class DataService : ISprint6Task1V27
    {
  // Calculates the values of the function for the given range.
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        // Calculate the number of values to be calculated.
        int count = stopValue - startValue + 1;

        // Create an array to store the calculated values.
        double[] values = new double[count];

        // Iterate through the range and calculate the function values.
        for (int i = 0; i < count; i++)
        {
            // Get the current value from the range.
            int x = startValue + i;

            // Calculate the function value.
            values[i] = Math.Round(CalculateFunctionValue(x));
        }

        // Return the array of function values.
        return values;
    }

    // Calculates the value of the function for the given x.
    private double CalculateFunctionValue(int x)
    {
        // Check if the denominator is zero.
        if (2 * x - 2 == 0)
        {
            // Return 0 if the denominator is zero.
            return 0;
        }
        else
        {
            // Calculate the function value.
            return 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
        }
    }
    }
}
