using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex3
{
  class Program
  {
    static void Main(string[] args)
    {

      string Pattern = @"\s+\d{3}$";
      Regex regexCheck = new Regex(Pattern);
      string Check = "full tally 020";

      Console.WriteLine($"Original: '{Check}' => '{regexCheck.Replace(Check, "")}'");

      Console.Write("\nPress any key...");
      Console.ReadKey();

    }
  }
}
