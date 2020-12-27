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
                var input = Console.ReadLine();
                if (input == "")
                    break;

                if (!double.TryParse(input, out double n))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if (n <= 0)
                {
                    Console.WriteLine("Число должно быть положительным \n");
                    continue;
                }

               

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

                int numberOfDays=FindN(n,m,k);
                

                Console.WriteLine($"\nЛыжник пробежит больше {k} км в {numberOfDays} день\n");

            }

        }
        static int FindN(double n, double m, double k)
            {
                int numberOfDays = 1;
                while (n < k)
                {
                    numberOfDays++;
                    n += n*m/100;
                }
                return numberOfDays;
            }
    }
}