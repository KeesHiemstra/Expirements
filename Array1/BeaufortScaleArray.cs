using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
	class BeafortScale
	{
		public static readonly Beaufort[] Scale = new Beaufort[13];

		public static void Initialize()
		{
			Scale[0] = new Beaufort  { Id =  0, Max_ms =  0.2m, Max_kmh =   1, Name = "Calm", Name_nl = "Windstil" };
			Scale[1] = new Beaufort  { Id =  1, Max_ms =  1.2m, Max_kmh =   5, Name = "Light air", Name_nl = "Zwakke wind" };
			Scale[2] = new Beaufort  { Id =  2, Max_ms =  3.3m, Max_kmh =  11, Name = "Light breeze", Name_nl = "Zwakke wind" };
			Scale[3] = new Beaufort  { Id =  3, Max_ms =  5.4m, Max_kmh =  19, Name = "Gentle breeze ", Name_nl = "Matige wind" };
			Scale[4] = new Beaufort  { Id =  4, Max_ms =  7.9m, Max_kmh =  28, Name = "Moderate breeze", Name_nl = "Matige wind" };
			Scale[5] = new Beaufort  { Id =  5, Max_ms = 10.7m, Max_kmh =  38, Name = "Fresh breeze", Name_nl = "Vrij krachtige wind" };
			Scale[6] = new Beaufort  { Id =  6, Max_ms = 13.8m, Max_kmh =  49, Name = "Strong breeze", Name_nl = "Krachtige wind" };
			Scale[7] = new Beaufort  { Id =  7, Max_ms = 17.1m, Max_kmh =  61, Name = "Near gale", Name_nl = "Harde wind" };
			Scale[8] = new Beaufort  { Id =  8, Max_ms = 20.7m, Max_kmh =  74, Name = "Gale", Name_nl = "Stormachtige wind" };
			Scale[9] = new Beaufort  { Id =  9, Max_ms = 24.4m, Max_kmh =  88, Name = "Strong gale", Name_nl = "Storm" };
			Scale[10] = new Beaufort { Id = 10, Max_ms = 28.4m, Max_kmh = 102, Name = "Storm", Name_nl = "Zware storm" };
			Scale[11] = new Beaufort { Id = 11, Max_ms = 32.6m, Max_kmh = 117, Name = "Violent Storm", Name_nl = "Zeer zware storm" };
			Scale[12] = new Beaufort { Id = 12, Max_ms = 99.9m, Max_kmh = 999, Name = "Hurricane", Name_nl = "Orkaan" };
		}

		public static int WindSpeedToBeafort1(decimal Speed)
		{
			int Result = 0;
			while (Result <= 12 && Speed > Scale[Result].Max_kmh)
			{
				Result++;
			}
			return Result;
		}

		//This methode is quicker
		public static int WindSpeedToBeaufort2(decimal Speed)
		{
			return (int)Scale
				.Last(x => x.Max_kmh < Speed).Id;
		}
	}

	class Beaufort
	{
		public byte Id { get; set; }
		public decimal Max_ms { get; set; }
		public int Max_kmh { get; set; }
		public string Name_nl { get; set; }
		public string Name { get; set; }
	}
}
