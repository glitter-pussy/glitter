using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace математические_формулы
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите значение х:");
            var x = double.Parse(Console.ReadLine());
            var y = F(x);
            Console.WriteLine("f(x) =" + y);
            Console.ReadKey();
        }
        static double F(double x)
        {
            return (Math.Abs(x) + 2 * Math.Sin(Math.Pow(Math.Tan(x),2) + 4)) / ( 5.5 * x);
        }
    }
}
