using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
  class Program
  {
    public enum Bits
    {
      x86, x64
    }

    const string Key32 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
    const string Key64 = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

    static void Main(string[] args)
    {
      WriteSoftwareSource(false);

      Console.Write("\nPress any key...");
      Console.ReadKey();
    }

    private static void WriteSoftwareSource(bool Bits64)
    {
      string[] strings = new string[2];
      strings[0] = Key32;
      strings[1] = Key64;

      Console.WriteLine(strings[0]);

      Console.WriteLine(Bits.x64.ToString());
    }
  }
}
