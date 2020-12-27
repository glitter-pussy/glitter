using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функция
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = double.Parse(Console.ReadLine());
            GetX(x);
            Console.ReadKey();
        }

           static void GetX(double x)
        {
            if (x < -1)
            {
                Console.WriteLine(" y = 1");
            }
            else if (-1 <= x && x <= 1)
            {
                Console.WriteLine(" y = " + GetYMiddle(x));
            }
            else
            {
                Console.WriteLine(" y = " + GetYUpper(x));
            }
        }
        static double GetYMiddle(double x)
        {
            return x * x;
        }
        static double GetYUpper(double x)
        {
            return 2 - x;
        }

    }
}
