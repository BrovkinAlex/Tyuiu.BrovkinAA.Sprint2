using Tyuiu.BrovkinAA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.BrovkinAA.Sprint1.Task3.V16
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
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #16                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y          *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь               *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры.                                  *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой                  *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.Write("Введите значение Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.Calculate(x);
            Console.WriteLine("Значение функции У = " + res);

            Console.ReadKey();
        }
    }
}
