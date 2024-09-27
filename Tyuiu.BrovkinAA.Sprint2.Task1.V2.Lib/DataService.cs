using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrovkinAA.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a < b) | (a > b);
            result[1] = (c!=a) & (c != d);
            result[2] = (a + d) < (b + c) || (a < d);
            result[3] = (a + 21 == b) && (c + 20 == d);
            result[4] = !(a > b + c + d);
            result[5] = (a < d) ^ (b > c);

            return result;
        }
    }
}
