using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace десятичная_запись
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


				if (!ulong.TryParse(input, out ulong n))
				{
					Console.WriteLine("Ошибка ввода\n");
					continue;
				}
				if (n <= 0)
				{
					Console.WriteLine("Число должно быть положительным ");
					continue;
				}
				ulong last = 0;
				do
				{
					last = n % 10;
				}
				while (n % 10 > 10);
				ulong count = 1;
				n /= 10;
				while (n != 0)
				{
					if (n % 10 == last)
						++count;
					n = n / 10;
				}




				Console.WriteLine($"Последний символ {last} в {input} встречается {count} раз\n");


			}




		}
	}
}
