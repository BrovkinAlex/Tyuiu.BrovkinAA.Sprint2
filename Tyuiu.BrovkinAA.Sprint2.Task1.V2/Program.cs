using Tyuiu.BrovkinAA.Sprint2.Task1.V2.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 135, b = 156, c = 154, d = 174;

            Console.Title = "Спринт 2 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #2                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу из операций сравнений и и логических операций,           *");
            Console.WriteLine("* а также арифметических выражений,которая вернет логическую                  *");
            Console.WriteLine("* последовательность(массив): (False, False, False, True, True, True)         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine($"a = {a}\nb = {b}\nc = {c}\nd = {d}");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < res.Length; i++)
                Console.WriteLine(res[i]);

            Console.ReadKey();
        }
    }
}
