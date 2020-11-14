using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace принадлежность_области
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetCoordinate("x");
            var y = GetCoordinate("y");

            string answer = "Нет";

            if (IsPointInArea(y))
                answer = "Да";

            Console.WriteLine("Принадлежит ли точка области? " + answer);

            Console.ReadKey();
        }

        static bool IsPointInArea(double y)
        {
            return 1 <= y || //точка в R1
                y <= -3;     //точка в R2
      
        }
        static double GetCoordinate (string coordinate)
        {
            Console.WriteLine("Введите координату " + coordinate);
            return double.Parse(Console.ReadLine());
        }
    }
}
