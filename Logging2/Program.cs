using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logging2
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(Log("Start message")); 

			Console.Write("\nPress any key...");
			Console.ReadKey();

		}

		static string Log(string message)
		{

			string LogFileName = Assembly.GetEntryAssembly().Location.Replace(".exe", ".log");

			using (StreamWriter stream = new StreamWriter(LogFileName, true))
			{
				stream.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {message}");
			}

			return message;

		}

	}
}
