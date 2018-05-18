using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex2
{
	class Program
	{
		public static List<Record> Records = new List<Record>();
		public static IDictionary<string, string> Masks = new Dictionary<string, string>();

		static void Main(string[] args)
		{
			Records.Add(new Record { TallyName = "Bank ABN", TallyDesciption = "Vast:ABN Af-Bank ABN" });
			Records.Add(new Record { TallyName = "Belasting Soesterberg", TallyDesciption = "Vast:ABN Af-Belasting Soesterberg" });
			Records.Add(new Record { TallyName = "Energie Meerkerk", TallyDesciption = "Vast:ABN Af-Energie Meerkerk" });
			Records.Add(new Record { TallyName = "Bank ING", TallyDesciption = "Vast:ING Af-Bank ING" });
			Records.Add(new Record { TallyName = "Belasting inkomen", TallyDesciption = "Vast:ING Af-Belasting inkomen" });
			Records.Add(new Record { TallyName = "Inkomen huis", TallyDesciption = "Vast:ABN Bij-Inkomen huis" });
			Records.Add(new Record { TallyName = "Inkomen Kees", TallyDesciption = "Vast:ING Bij-Inkomen Kees" });
			Records.Add(new Record { TallyName = "Boodschappen Meerkerk", TallyDesciption = "Onverzien:ING Af-" });
			Records.Add(new Record { TallyName = "Boodschappen Soesterberg", TallyDesciption = "Onverzien:ABN Af-" });
			//Non matching TallyDescriptions
			Records.Add(new Record { TallyName = "Prijsje", TallyDesciption = "Onvoorzien:ING Bij-Prijsje" });
			Records.Add(new Record { TallyName = "", TallyDesciption = "" });

			Masks.Add("Gezamenlijk af", "^Vast:ABN Af-");
			Masks.Add("Persoonlijk af", "^Vast:ING Af-");
			Masks.Add("Onvoorzien af", "^Onverzien:(ABN|ING) Af-");
			Masks.Add("Inkomsten", "^Vast:(ABN|ING) Bij-");
			Masks.Add("Alles", "(^(Vast|Onverzien):(ABN|ING)\\s(Af|Bij)-)");

			#region Starting
			Console.WriteLine(Masks);
			Console.WriteLine();

			foreach (var item in Masks)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}

			//Show the value of the Mask
			Console.WriteLine();
			Console.WriteLine(Masks["Onvoorzien af"]);

			Console.WriteLine();
			Console.WriteLine($"Match 'Vast:ABN Af-Bank ABN:' {"Vast:ABN Af-Bank ABN".Match(Masks["Gezamenlijk af"])}");
			Console.WriteLine($"Match 'Vast:ABN Af-Bank ABN:' {"Vast:Rabo Af-Bank ABN".Match(Masks["Gezamenlijk af"])}");
			#endregion

			Console.WriteLine();
			foreach (var mask in Masks)
			{
				var Matches = Records.Where(x => x.TallyDesciption.Match(Masks[mask.Key]));
				Console.WriteLine($"Section {mask.Key} ({Matches.Count()}):");
				foreach (var item in Matches)
				{
					Console.WriteLine($"- {item.TallyName}");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			var NotMatches = Records.Where(x => x.TallyDesciption.Match(Masks["Alles"], false));
			Console.WriteLine($"Section gemist ({NotMatches.Count()}):");
			foreach (var item in NotMatches)
			{
				Console.WriteLine($"- {item.TallyName}");
			}

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}

	public static class StringExtensions
	{
		public static bool Match(this string model, string pattern, bool match = true)
		{
			bool result = false;

			Regex regex = new Regex(pattern);
			result = regex.IsMatch(model) == match;

			return result;
		}
	}

	public class Record
	{
		public string TallyName { get; set; }

		public string TallyDesciption { get; set; }
	}
}
