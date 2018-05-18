using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

			Masks.Add("Gezamenlijk af", "Vast:ABN Af-");

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}

	public class Record
	{
		public string TallyName { get; set; }

		public string TallyDesciption { get; set; }
	}
}
