using Tyuiu.BrovkinAA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task7.V3
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
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #3                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные и             *");
            Console.WriteLine("* вычисляет, находится ли точка с координатами X,Y в заштрихованной области.  *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("График фунции  x^2 + (y-1)^2 = 1  --  Окружность с радиусом 1 и центром в точке (0, 1)");
            Console.WriteLine("График фунции  y = 1 - x^2  -- Парабола с вершиной в точке (0, 1), ветви направлены вниз");

            Console.Write("Введите значение Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение У: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка НЕ находится в заштрихованной области");

            Console.ReadKey();
        }
    }
}
