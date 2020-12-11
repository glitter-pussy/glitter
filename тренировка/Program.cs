using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тренировки
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Сколько лыжник пробежал в первый день?");

                if (!double.TryParse(Console.ReadLine(), out double n))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if (n <= 0)
                {
                    Console.WriteLine("Число должно быть положительным \n");
                    continue;
                }

                string str = n.ToString();
                if (str == "")
                    break;

                Console.WriteLine("На сколько он увеличивал пробег каждый день (в процентах)");

                if (!double.TryParse(Console.ReadLine(), out double m))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if (m <= 0)
                {
                    Console.WriteLine("Число должно быть положительным \n");
                    continue;
                }
                Console.WriteLine("Введите число км, больше которого лыжник должен пробежать");

                if (!double.TryParse(Console.ReadLine(), out double k))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if (k <= 0)
                {
                    Console.WriteLine("Число должно быть положительным\n");
                    continue;
                }

                int numberOfDays = 1;

                while (n < k)
                {
                    numberOfDays++;
                    n += n / m;

                }

                Console.WriteLine($"\nЛыжник пробежит больше {k} км в {numberOfDays} день\n");

            }
        }
    }
}