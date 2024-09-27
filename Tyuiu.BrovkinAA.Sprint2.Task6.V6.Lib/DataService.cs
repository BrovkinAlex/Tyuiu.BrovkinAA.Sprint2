using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BrovkinAA.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res = value2 switch
            {
                6 => "Шестерка ",
                7 => "Семерка ",
                8 => "Восьмерка ",
                9 => "Девятка ",
                10 => "Десятка ",
                11 => "Валет ",
                12 => "Дама ",
                13 => "Король ",
                14 => "Туз ",
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
