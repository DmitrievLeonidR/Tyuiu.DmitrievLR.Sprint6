using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int arrayLength = stopValue - startValue + 1;

            double[] functionValues = new double[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {

                int x = startValue + i;

                functionValues[i] = CalculateFunctionValue(x);
            }

            return functionValues;
        }

        private double CalculateFunctionValue(int x)
        {

            if (Math.Sin(x) - 2 == 0)
            {
                return 0;
            }

            double functionValue = (5 * x + 2.5) / (Math.Sin(x) - 2) + 2;

            return Math.Round(functionValue, 2);
        }
    }
}
