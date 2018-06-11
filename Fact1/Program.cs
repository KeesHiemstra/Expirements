using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fact1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Test1();

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}

		[Fact]
		static void Test1()
		{
			DateTime Check = DateTime.Now;

			Assert.Equal(Check, DateTime.Now);
		}
	}
}
