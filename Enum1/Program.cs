using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************
 * Use enum and combine it direction in the wind rose
 * 
 * 2018-06-11: Kees Hiemstra
 */
namespace Enum1
{
	#region Compass enum
	/// <summary>
	/// Compass in degrees * 10 to get half degree percission.
	/// </summary>
	public enum Compass
	{
		N = 0,
		NNE = 225,
		NE = 450,
		ENE = 675,
		E = 900,
		ESE = 1125,
		SE = 1350,
		SSE = 1575,
		S = 1800,
		SSW = 2025,
		SW = 2250,
		WSW = 2475,
		W = 2700,
		WNW = 2925,
		NW = 3150,
		NNW = 3375
	}
	#endregion

	class Program
	{
		enum Compass4
		{
			N = 0,
			E = 90,
			S = 180,
			W = 270
		}
		enum Compass8
		{
			N = 0,
			NE = 45,
			E = 90,
			SE = 135,
			S = 180,
			SW = 225,
			W = 270,
			NW = 315
		}
		static void Main(string[] args)
		{
			Console.WriteLine(Compass4.N);

			Compass4 myDegrees4 = (Compass4)90;
			Console.WriteLine(myDegrees4);

			int intDegrees = 270;
			Compass8 myDegrees8 = (Compass8)intDegrees;
			Console.WriteLine("Input {0}: {1}", intDegrees, myDegrees8);

			Console.WriteLine(myDegrees4.GetType());
			Console.WriteLine(myDegrees4.GetTypeCode());
			Console.WriteLine(myDegrees4.GetHashCode());
																 
			string directionName = myDegrees8.ToString();
			Console.WriteLine(directionName);

			Console.WriteLine();
			for (int degrees = -15; degrees <= 15; degrees += 3)
			{
				decimal inputDegrees = (decimal)degrees;
				Console.WriteLine("{0}: {1}", inputDegrees, inputDegrees.DegreesToCompass());
			}

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}

	public static class EnumExtensions
	{
		#region DegreesToCompass
		/// <summary>
		/// Calculate direction in degrees to Compass direction.
		/// </summary>
		/// <param name="Direction">In degrees</param>
		/// <returns></returns>
		public static Compass DegreesToCompass(this decimal Direction)
		{
			const int Around = 360;

			//Corrections to Directions between 0 and 360 degrees
			while (Direction < 0)
			{
				Direction += Around;
			}
			while (Direction > Around)
			{
				Direction -= Around;
			}
			//Calculate with int instead of decimal to avoid rounding errors
			int direction = (int)Direction * 100;

			//Calculate that compass is between a half compass before and after it 
			int compass = ((direction + 1125) / 2250) * 2250;

			//Correct the calculate to use precission in degree * 10
			compass = compass / 10;
			if (compass >= 3600)
			{
				compass -= 3600;
			}

			return (Compass)(compass);
		}
		#endregion
	}
}
