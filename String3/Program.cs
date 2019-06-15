using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
	class Program
	{
		static void Main(string[] args)
		{
			string Test = "123456789";

			Console.WriteLine(Test);
			Console.WriteLine($"Length: {Test.Length}");

			Console.WriteLine(Test[1]);

			Console.Write("\nPress any key...");
			Console.ReadKey();
		}
	}
}
