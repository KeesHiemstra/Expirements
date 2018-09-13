using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

/**************
 * Avoid double to calculate to mistakes with extra decimals.
 * 
 * 
 */ 
namespace Fact1
{
	public class Program
	{
		static void Main(string[] args)
		{
			TestDouble();
			TestInteger();

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}

		public static double DoubleKelvin2Celcius(double kelvin)
		{
			const double K0 = 273.15;
			return kelvin - K0;
		}

		public static double IntegerKelvin2Celcius(double kelvin)
		{
			const int K0 = 27315;
			int kelvin100 = (int)(kelvin * 100);

			return (double)(kelvin100 - K0) / 100;
		}

		[Fact]
		private static void TestDouble()
		{
			double kelvin = 294.25;
			double result = DoubleKelvin2Celcius(kelvin);

			Assert.NotEqual(21.1, result);
		}

		[Fact]
		private static void TestInteger()
		{
			double kelvin = 294.25;
			double result = IntegerKelvin2Celcius(kelvin);

			Assert.Equal(21.1, result);
		}
	}
}
