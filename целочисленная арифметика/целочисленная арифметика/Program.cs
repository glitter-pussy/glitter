using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace целочисленная_арифметика
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n, x;
            Console.WriteLine("Введите трехзначное число:");
            n = int.Parse(Console.ReadLine());
            a = n / 100;
            b = (n / 10) % 10;
            c = n % 10;
            x = 100 * a + 10 * c + b;
            Console.WriteLine();
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
