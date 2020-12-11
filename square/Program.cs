using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace square
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Введите натуральное число(Exit- выход)");
				var input = Console.ReadLine();
				if (input == string.Empty)
					break;
				int n;
				if (!int.TryParse(input, out n))
				{
					Console.WriteLine("Ошибка ввода\n");
					continue;
				}
				if (n <= 1)
				{
					Console.WriteLine("Число должно быть положительным и больше 1 ");
					continue;
				}


				Console.WriteLine("Числа, квадрат которых меньше, чем введенное число\n");
				for (var i = 1; i * i < n; i++)
				{
					Console.WriteLine($"{i} \n");


				}


			}
		}
	}
}
