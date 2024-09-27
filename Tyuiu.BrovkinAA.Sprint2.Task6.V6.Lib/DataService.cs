using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrovkinAA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res = value2 switch
            {
                6 => "шестерка ",
                7 => "семерка ",
                8 => "восьмерка ",
                9 => "девятка ",
                10 => "десятка ",
                11 => "валет ",
                12 => "дама ",
                13 => "король ",
                14 => "туз ",
                _ => throw new ArgumentException($"Достоинтсво карты от 6 до 14. Введено значение{value2}")
            };
            res += value1 switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => throw new ArgumentException($"Масть карт от 1 до 4. Введено значение{value1}")
            };
            return res;
        }
    }
}
