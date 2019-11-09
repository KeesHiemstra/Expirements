using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime date = new DateTime(2019, 3, 31);

      Console.WriteLine($"{date} - 1 month = {date.AddMonths(-1)}");

      Console.WriteLine("\nPress any key...");
      Console.ReadKey();
    }
  }
}
