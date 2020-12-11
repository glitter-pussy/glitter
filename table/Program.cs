using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace table
{
	class Program
	{
		static void Main()
		{
			while (true)
			{
                Console.WriteLine("Введите первое число в таблице (в сантиметрах)");
                var input1 = Console.ReadLine();

                if (input1.Length < 1)
                    break;

                if (!double.TryParse(input1, out double a))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }


                Console.WriteLine("Введите шаг таблицы (в сантиметрах)");
				var input2 = Console.ReadLine();

				if (input2.Length < 1)
					break;

				if (!double.TryParse(input2, out double h))
				{
					Console.WriteLine("Ошибка ввода\n");
					continue;
				}
				Console.WriteLine("Введите последнее число в таблице (в сантиметрах)");
				var input3 = Console.ReadLine();

				if (input3.Length < 1)
					break;

				if (!double.TryParse(input3, out double b))
				{
					Console.WriteLine("Ошибка ввода\n");
					continue;
				}




				Console.WriteLine("\x250C" + new String((char)0x2500, 7) + "\x252C" + new String((char)0x2500, 8) + "\x2510");
				Console.WriteLine("\x2502  см   \x2502  дюймы \x2502");
				Console.WriteLine("\x251C" + new String((char)0x2500, 7) + "\x253C" + new String((char)0x2500, 8) + "\x2524");


				var valInCm = a;


				while (valInCm <= b)
				{
					var valInInches = valInCm / 2.54;
					Console.WriteLine($"\x2502 {valInCm,5:F2} \x2502 {valInInches,6:F2} \x2502");
					valInCm += h;
				}




				Console.WriteLine("\x2514" + new String((char)0x2500, 7) + "\x2534" + new String((char)0x2500, 8) + "\x2518");


				break;
			}
		}

	
		}
	}
