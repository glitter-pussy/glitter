using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace двумерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            var tryAgain = true;

            while (tryAgain)
            {
                Console.WriteLine("Введите число строк (m)");
                var input = Console.ReadLine();

                if (int.TryParse(input, out m) && m >= 5 && m <= 20)
                {
                    while (true)
                    {
                        Console.WriteLine("Введите число столбцов (n)");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out n) && n >= 5 && n <= 20)
                        {
                            tryAgain = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода\n");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
            }

            var table = CreateArray(m, n);

            PrintTable(table);
            GetIndexofRow(table);
            GetSum(table);


            Console.ReadKey();
        }

        static int[,] CreateArray(int m, int n)
        {
            var rnd = new Random();

            var table = new int[m, n];

            for (var i = 0; i < table.GetLength(0); i++)
                for (var j = 0; j < table.GetLength(1); j++)
                    table[i, j] = rnd.Next(0, 100);
            return table;
        }

        static void PrintTable(int[,] t)
        {
            for (var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j],2} ");

                Console.WriteLine();
            }
        }


        static void GetIndexofRow(int[,] t)
        {
            bool result = true;
            int number = 0;

            for (int j = 0; j < t.GetLength(1); j++)
            {
                int subsequentElem = int.MaxValue;
                Console.WriteLine($"\nЭлементы, нарушающие последовательность в столбце {j + 1}:");


                for (int i = 0; i < t.GetLength(0); i++)
                {

                    int currentElem = t[i, j];
                    if (subsequentElem <= currentElem)
                    {

                        Console.Write($"({j + 1}, {i + 1}) ");
                        ++number;
                        if (result)
                            continue;
                    }
                    subsequentElem = currentElem;

                }
                if (number == 0)
                    Console.WriteLine(" 0. Элементы идут в порядке убывания");
                number = 0;


            }
        }


        static void GetSum(int[,] t)
        {
            for (int i = 0; i < t.GetLength(0); i++)
            {
                int sum=0;
                for (var j = 0; j < t.GetLength(1); j++)
                {
                    int elem = t[i, j];
                    if (elem % 2 == 0)
                        sum += elem;
                }

                    Console.Write($"\nСтрока: {i+1} сумма всех четных: {sum}\n");

                
            }

        }

    }

}

