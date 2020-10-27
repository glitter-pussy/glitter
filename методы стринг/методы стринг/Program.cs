using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace методы_стринг
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "перемена";
            Console.WriteLine(s1);
            Console.WriteLine(s1.Substring(4, 2) + s1.Substring(2, 1) + s1.Substring(7, 1));
            Console.WriteLine(s1.Substring(6, 1) + s1.Substring(1, 2) + s1.Substring(0, 1) + s1.Substring(7, 1));
            Console.ReadKey();
                } } }