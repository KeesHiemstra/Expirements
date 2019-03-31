using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetType1
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass MyObject = new MyClass { LastName = "Hiemstra", FirstName = "Kees", Age = 50 };

			Console.WriteLine(MyObject.GetType());

			Console.WriteLine(MyObject.GetType().GetFields());
			foreach (var item in MyObject.GetType().GetFields())
			{
				Console.WriteLine(item.FieldType);
			}
			Console.WriteLine();

			Console.WriteLine(MyObject.GetType().GetMembers());
			foreach (var item in MyObject.GetType().GetMembers())
			{
				Console.WriteLine($"{item.MemberType} = {item.Name} ({item.ToString()})");
			}
			Console.WriteLine();

			Console.WriteLine(MyObject.GetType().GetProperties());
			foreach (var item in MyObject.GetType().GetProperties())
			{
				Console.WriteLine($"{item.Name}: {item.GetValue(MyObject)}");
			}


			Console.Write("\nPress any key...");
			Console.ReadKey();
		}
	}

	public class MyClass
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
	}
}
