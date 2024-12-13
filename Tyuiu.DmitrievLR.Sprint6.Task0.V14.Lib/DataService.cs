using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DmitrievLR.Sprint6.Task0.V14.Lib
{
    public class DataService : ISprint6Task0V14
    {
        public double Calculate(int x)
        {

            double y = (Math.Pow( (1-x) ,2)) / (-3*x);

            return y;
        }
    }
}
