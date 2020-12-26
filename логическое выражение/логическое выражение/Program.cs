using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace логическое_выражение
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = GetNumber("k");
            var m = GetNumber("m");
            var n = GetNumber("n");

            string answer = "Нет.";

            if (EvaluateLogicalExpression(k, m, n))
                answer = "Да";

            Console.WriteLine("Верно ли, что только одно из чисел k, m, или n больше 15? " +
                answer);

            Console.ReadKey();
        }

        static bool EvaluateLogicalExpression(int k, int m, int n)
        {
            bool result = false;
            if (k > 15 && m <= 15 && n <= 15)
                result = true;
            if (k <= 15 && m > 15 && n <= 15)
                result = true;
            if (k <= 15 && m <= 15 && n > 15)
                result = true;
            return result;
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine("Введите число " + numberName);
            return int.Parse(Console.ReadLine());
        }
    }
}
