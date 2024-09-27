using Tyuiu.BrovkinAA.Sprint2.Task4.V11.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task4.V11
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
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #11                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                    *");
            Console.WriteLine("* с использованием тернарного оператора, где пользователь                     *");
            Console.WriteLine("* вводит значение переменной X, У с клавиатуры.                               *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой                  *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.Write("Введите значение Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение У: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.Calculate(x, y);
            Console.WriteLine("Значение функции Z = " + res);

            Console.ReadKey();
        }
    }
}
