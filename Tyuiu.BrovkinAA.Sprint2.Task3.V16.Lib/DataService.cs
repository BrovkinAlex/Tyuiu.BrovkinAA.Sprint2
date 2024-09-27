using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)            
                res = x + Math.Pow(((x + 1) / (x - 1)), 3);            
            else if (x == 0)
            {
                double top = 2 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                double bottom = 5 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                res = top / bottom;
            }
            else if (-20 < x && x < 2)            
                res = Math.Pow((1 + (1 / Math.Pow(x, 2))), 7);            
            else
                res = x + (10 * x) - (1 / x);

            return Math.Round(res, 3);
        }
    }
}
