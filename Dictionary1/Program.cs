using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
	public class Program
	{
		public static readonly IDictionary<string, string> Dict = new Dictionary<string, string>()
		{
			{ "Bft", "Beaufort" },
			{ "K", "Kelvin" },
			//Degree Sign = Alt+0176
			{ "°C", "degree Celsius" },
			{ "°F", "degree Fahrenheit" },
			{ "km/h", "kilometer per hour" },
			{ "m/s", "meter per second" }
		};

		static void Main(string[] args)
		{

			foreach (var item in Dict)
			{
				Console.WriteLine($"{item.Key, 6} {item.Value}");
			}

			Console.WriteLine();

			Console.WriteLine($"21°C ({ Dict["°C"] })");

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}

	}
}
