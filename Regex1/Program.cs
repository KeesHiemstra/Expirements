using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex1
{
	class Program
	{
		static void Main(string[] args)
		{
			CheckString("This is the first/second check.");

			Console.Write("Press any key...");
			Console.ReadKey();
		}

		private static void CheckString(string v)
		{
			Console.WriteLine(ReplaceCharacters(v));
		}

		#region Replace all characters
		/// <summary>
		/// Replace the characters in Pattern to hyphen without loops.
		/// </summary>

		const string Pattern = @"([\s,.//\\-_=])+";

		private static readonly Regex regexCheck = new Regex(Pattern);

		public static string ReplaceCharacters(string v)
		{
			return regexCheck.Replace(v, "-"); ;
		}
		#endregion
	}
}
