using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
     class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите натуральное число");
                var input = Console.ReadLine();
                if (input.Length == 0)
                    break;

                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                if (number <= 1)
                {
                    Console.WriteLine("Число должно быть положительным и не равно 1\n");
                    continue;
                }
                if (number == 2)
                {
                    Console.WriteLine("Простых чисел меньше не существует\n");
                continue;
                }


                int[] allLowerNumbers = new int[number - 1];
                for (int i = 2; i < number; i++)
                {
                    allLowerNumbers[i - 2] = i;
                }
                int[] crossedNumbers = new int[number - 2];

                PrintLowerPrimeNumbers(allLowerNumbers, crossedNumbers, number);

            }
        }
        static void PrintLowerPrimeNumbers(int[] allLowerNumbers, int[] crossedNumbers, int input)
        {
            while (true)
            {
                int step = 0;
                for (int i = 0; i < crossedNumbers.Length; i++)
                {
                    if (crossedNumbers[i] == 0)
                    {
                        crossedNumbers[i] = 2;
                        step = allLowerNumbers[i];
                        break;
                    }
                }

                if (step == 0)
                    break;

                for (int i = step * 2 - 2; i < crossedNumbers.Length; i += step)
                    crossedNumbers[i] = 1;

            }

            Console.WriteLine("\nПростые числа, меньше введенного");


            for (int i = 0; i < crossedNumbers.Length; i++)
            {
               
                if ((crossedNumbers[i] != 1) && (allLowerNumbers[i])!= input)
                    Console.Write($"{allLowerNumbers[i]} ");
            }


            Console.WriteLine("\n");
        }
    }
}