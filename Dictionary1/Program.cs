using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
	public class Program
	{
		public static readonly IDictionary<string, string> Dict = new Dictionary<string, string>();

		static void Main(string[] args)
		{
			Initilize();

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

		#region Initilize Dict dictionary
		public static void Initilize()
		{
			//Degree Sign = Alt+0176
			Dict.Add("Bft", "Beaufort");
			Dict.Add("K", "Kelvin");
			Dict.Add("°C", "degree Celcius");
			Dict.Add("°F", "degree Fahrenheit");
			Dict.Add("km/h", "kilometer per hour");
			Dict.Add("m/s", "meter per second");
		}
		#endregion
	}
}
