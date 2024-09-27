using Tyuiu.BrovkinAA.Sprint2.Task0.V26.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1045, y = 975;

            Console.Title = "Спринт 2 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #26                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,        *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                       *");
            Console.WriteLine("* (False, False, False, True, True, True)                                     *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine($"X = {x}\nY = {y}");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            bool[] res = ds.GetCompareOperations(x, y);
            for (int i = 0; i < res.Length; i++)
                Console.WriteLine(res[i]);

            Console.ReadKey();
        }
    }
}
