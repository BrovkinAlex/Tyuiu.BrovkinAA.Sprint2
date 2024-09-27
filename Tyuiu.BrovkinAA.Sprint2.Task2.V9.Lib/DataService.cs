using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrovkinAA.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if(x < 3 || x > 13 || y < 2 || y > 12) return false;

            if((x == 3 || x == 5) && (y > 4 && y < 11)) return false;
            if(x == 6 && y > 9) return false;
            if(x == 7 && (y < 9 && y != 6)) return false;
            if(x == 8 && y < 5) return false;
            if(x == 13 && (y < 6 || y > 8)) return false;

            if(y == 12 && (x < 7 || x > 10)) return false;

            return true;
        }
    }
}
