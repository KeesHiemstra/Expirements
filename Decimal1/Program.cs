using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"1.00 => {decimal.Parse("1.00")} / 1,00 {decimal.Parse("1,00")}");

			bool DivideBy100 = (decimal.Parse("1.25") == 125);

			string Record = "5,25";
			decimal Amount = decimal.Parse(Record.Replace(',', '.'));
			if (DivideBy100)
			{
				Console.WriteLine("Divide by 100");
				Amount /= 100;
			}

			Console.WriteLine(Amount);

			Console.WriteLine("\nPress any key...");
			Console.ReadKey();
		}
	}
}
