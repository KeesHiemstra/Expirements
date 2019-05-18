using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exception1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
                throw new AccessViolationException();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"{ex.Source}: 0x{ex.HResult:X}\n{ex.Message}");
			}

			Console.Write("\nPress any key");
			Console.ReadKey();
		}
	}
}
