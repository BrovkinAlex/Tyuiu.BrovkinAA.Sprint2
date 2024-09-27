using Tyuiu.BrovkinAA.Sprint2.Task5.V1.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task5.V1
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
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #1                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая использует оператор switch и, по данному        *");
            Console.WriteLine("* номеру месяца, определяет количество дней в этом месяце.                    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.Write("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            if (month < 1 || month > 12)
                Console.WriteLine("Неверный номер месяца");
            else
            {
                int countDays = ds.FindMonthDaysCount(month);
                Console.WriteLine($"Количество дней в {month} месяце: {countDays}");
            }

            Console.ReadKey();
        }
    }
}
