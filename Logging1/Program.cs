using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace Logging1
{
	class Program
	{

		public static ILogger Logger { get; set; } = new LoggerFactory().CreateLogger<Program>();

		public static void Initialize()
		{
			//Logger = new LoggerFactory()
			//.AddConsole(LogLevel.Information)
			//.AddDebug(LogLevel.Debug)
			//.CreateLogger<Program>();
		}

		static void Main(string[] args)
		{
			Logger.LogInformation($"Retrieving samples from '{nameof(Main)}'");

			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}
}
