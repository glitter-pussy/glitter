using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace метод_функция
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetValue();
            Console.WriteLine("x=" + x);
            Console.ReadKey();
        }
        static double GetValue()
        {
            return F(3, 2) + F(5, 3) + F(11, 7);
        }
        static double F(double a, double b)
        {
            return (Math.Sqrt(a) - Math.Sqrt(b)) / (Math.Sqrt(a) + Math.Sqrt(b));
        }
    }
}
