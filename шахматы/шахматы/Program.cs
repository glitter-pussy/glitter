using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шахматы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого коня");
            var positionWhite = Console.ReadLine().ToLower();

            Console.WriteLine("Введите позицию черного коня");
            var positionBlack = Console.ReadLine().ToLower();

            Console.WriteLine("Введите ход белого коня");
            var moveWhite = Console.ReadLine().ToLower();

            string answer = "Нет";
            if (GetMove(positionWhite, moveWhite) &&
                 GetMove(positionWhite, moveWhite) != GetMove(positionBlack, moveWhite) &&
                 !GetMove(positionBlack, moveWhite))
                answer = "Да";

            Console.WriteLine("Возможность хода: " + answer );

            Console.ReadKey();
        }

        static void Position(string position,
            out int column, out int row)
        {
            column = position[0];
            row = position[1];
        }

        static bool GetMove(string start, string end)
        {
            Position(start, out int startColumn, out int startRow);
            Position(end, out int endColumn, out int endRow);

            return Math.Abs(startRow - endRow) == 2 && Math.Abs(startColumn - endColumn) == 1 ||
                Math.Abs(startRow - endRow) == 2 && Math.Abs(endColumn - startColumn) == 1 ||
                                 Math.Abs(startColumn - endColumn) == 2 && Math.Abs(startRow - endRow) == 1 ||
                                                 Math.Abs(startColumn - endColumn) == 2 && Math.Abs(endRow - startRow) == 1;
        }
    }
}
