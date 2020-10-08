using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вычисление_заданных_величин
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, n, k;
            Console.WriteLine("введите стороны прямоугольника:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            n = 2 * (a + b);
            Console.WriteLine("периметр прямоугольника:" + n);
            k = a * b;
            Console.WriteLine("площадь прямоугольника:" + k);
            c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("длина диагонали прямоугольника:" + c);

            Console.ReadKey();
        }
    }
}
