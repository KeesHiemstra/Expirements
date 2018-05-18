using Newtonsoft.Json;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryFromJson1
{
	class Program
	{
		private const string JsonFile = "..\\..\\Masks.json";

		static void Main(string[] args)
		{
			string json = string.Empty;

			try
			{
				using (StreamReader sr = new StreamReader(JsonFile))
				{
					json = sr.ReadToEnd();
				}
			}
			catch (Exception e)
			{

				throw;
			}

			IDictionary<string, string> Masks = new Dictionary<string, string>();
			Masks = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

			foreach (var item in Masks)
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}
}
