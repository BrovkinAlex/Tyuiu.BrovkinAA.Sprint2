using Tyuiu.BrovkinAA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.BrovkinAA.Sprint2.Task6.V6
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
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #6                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора   *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.                 *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты         *");
            Console.WriteLine("* k (6 <= k <= 14) определить полное название (масть и достоинство)           *");
            Console.WriteLine("* соответствующей карты                                                       *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.Write("Введите масть карты: ");
            int suit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите достоинство карты: ");
            int value = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            if ((1 <= suit && suit <= 4) && (6 <= value && value <= 14))            
                Console.WriteLine("Ваша карта: " + ds.FindCardNameAndValue(suit, value));
            else
                Console.WriteLine("Неверное достоинство карты или ее масть");

            Console.ReadKey();
        }
    }
}
