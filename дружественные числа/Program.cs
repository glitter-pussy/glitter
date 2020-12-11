using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дружественные_числа
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while(true){
            Console.WriteLine("Введите значение, в пределах которого искать дружественные числа (Enter — отказ)");
                var input = Console.ReadLine();

                if (input.Length < 1)
                    break;

                if(!int.TryParse(input, out int n))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
            for (int i = 0; i <= n; i++)
            {
                if (SummarizeDividers(SummarizeDividers(i)) == i && SummarizeDividers(i) != i)
                    Console.WriteLine($"\n{i} и {SummarizeDividers(i)}\n");
            }
            }
        }
        static int SummarizeDividers(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
                {
                if (number % i == 0  ) 
                    sum += i;
                }
            return sum;
        }
 
    }
}
    