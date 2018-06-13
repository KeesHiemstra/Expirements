using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal WindSpeed = 90.5m;
			TimeSpan Elapsed;

			BeafortScale.Initialize();

			DateTime Start = DateTime.Now;

			Console.WriteLine($"{WindSpeed} km/h is {BeafortScale.WindSpeedToBeafort1(WindSpeed)} Bft"); 

			Elapsed = DateTime.Now - Start;
			Console.WriteLine($"This costs {Elapsed.Milliseconds} milliseconds");
			Console.WriteLine();

			Start = DateTime.Now;

			Console.WriteLine($"{WindSpeed} km/h is {BeafortScale.WindSpeedToBeaufort2(WindSpeed)} Bft");

			Elapsed = DateTime.Now - Start;
			Console.WriteLine($"This costs {Elapsed.Milliseconds} milliseconds");
			Console.WriteLine();

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}
}
