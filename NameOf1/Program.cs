using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOf1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"{nameof(Main)} ...");

			Check();

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}

		private static void Check()
		{
			Console.WriteLine($"{nameof(Check)} ...");
		}
	}
}
