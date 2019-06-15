using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime Birthday = new DateTime(1999, 5, 22);

			Console.WriteLine($"Birthday {Birthday.ToLongDateString()}");

			Console.Write("\nPress any key...");
			Console.ReadKey();
		}
	}
}
