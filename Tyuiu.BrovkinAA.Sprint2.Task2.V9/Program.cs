using Tyuiu.BrovkinAA.Sprint2.Task2.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 2 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                 *");
            Console.WriteLine("* Задание #2                                                                  *");
            Console.WriteLine("* Вариант #9                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры      *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области. *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.Write("Введите значние Х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение У: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res) Console.WriteLine("Точка находится в заштрихованной области");
            else Console.WriteLine("Точка НЕ находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}
