using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrovkinAA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((1 <= x || x <= -1) && (1 <= y || y <= -1)) return false;

            bool circle = ((x * x) + Math.Pow(y - 1, 2)) <= 1;
            bool parabola = (1 - x * x) >= y;

            return circle && parabola;
        }
    }
}
