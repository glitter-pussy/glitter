using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив
{
    class Program

    {

        static void Main(string[] args)
        {
            double p;
            double q;
            double k;

            while (true)
            {
                Console.WriteLine("Введите первый член последовательности");

                if (!double.TryParse(Console.ReadLine(), out p))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                Console.WriteLine("Введите знаменатель последовательности");

                if (!double.TryParse(Console.ReadLine(), out q))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                if (q == 1 || q == 0)
                {
                    Console.WriteLine("знаменатель не должен быть равен 0 или 1");
                    continue;
                }

                break;
            }

            Console.WriteLine();

            var geometricProgression = CreateArray(p,q);

            PrintGeometricProgression(geometricProgression);

            PrintSquare(geometricProgression);
                        Console.WriteLine();


            FindGeometricAverage(geometricProgression);
                        Console.WriteLine();
                        Console.WriteLine();



            while (true)
            {
                Console.WriteLine("Введите множитель k");

                if (!double.TryParse(Console.ReadLine(), out k))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
                break;
            }
             
            Console.WriteLine();


            PrintMul(geometricProgression, k);

            Console.ReadKey();
        }

        static double[] CreateArray(double p, double q)
        {
           var geometricProgression = new double[20];
            
            for (var i = 1; i <= 20; i++)
            {
                geometricProgression[i - 1] = (p * Math.Pow(q, i - 1));
            }

            return geometricProgression;
        }

        static void PrintGeometricProgression(double[] geometricProgression)
        {

            Console.WriteLine("Геометрическая прогрессия:");

            foreach (var elem in geometricProgression)
                IsRight(elem);

            Console.WriteLine();

        }

        static void PrintSquare(double[] geometricProgression)
        {
            Console.WriteLine("Члены геометрической прогрессии, возведенные в квадрат:");

            for (int i = 0; i < 20; i++)
            {
                geometricProgression[i] = Math.Pow(geometricProgression[i], 2);
            }

            foreach (var number in geometricProgression)
                IsRight(number);


            Console.WriteLine();

        }

        static void FindGeometricAverage(double[] geometricProgression)
        {
            Console.WriteLine("Среднее геометрическое:");


            double multiplication = 1;

            foreach (var elem in geometricProgression)
            {
                multiplication *= elem;
            }
            double averGeom = Math.Pow(multiplication, 1.0 / geometricProgression.Length);
            IsRight(averGeom);

        }

        static void PrintMul(double[] geometricProgression, double k)
        {
            Console.WriteLine("Числа, умноженные на k");

            foreach (var elem in geometricProgression)
            {
                double num = elem;
                num *= k;
                IsRight(num);
            }

        }

        static void IsRight(double num)
        {
            if (num < double.MaxValue)
            Console.Write($"{num} ");

            else
                Console.Write($"Число слишком большое ");
        }


    }
}