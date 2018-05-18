using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGroupBy1
{
	class Program
	{
		public static List<Record> Records = new List<Record>();

		static void Main(string[] args)
		{
			Records.Add(new Record { Id = 1, Date = new DateTime(2018, 04, 23), Count = 1, ShopItemName = "Breadloaf" });
			Records.Add(new Record { Id = 2, Date = new DateTime(2018, 04, 30), Count = 1, ShopItemName = "Breadloaf" });
			Records.Add(new Record { Id = 3, Date = new DateTime(2018, 05, 07), Count = 1, ShopItemName = "Breadloaf" });
			Records.Add(new Record { Id = 8, Date = new DateTime(2018, 05, 12), Count = 1, ShopItemName = "Breadloaf" });
			Records.Add(new Record { Id = 4, Date = new DateTime(2018, 04, 23), Count = 2, ShopItemName = "Cheese" });
			Records.Add(new Record { Id = 5, Date = new DateTime(2018, 04, 30), Count = 2, ShopItemName = "Cheese" });
			Records.Add(new Record { Id = 6, Date = new DateTime(2018, 05, 07), Count = 2, ShopItemName = "Cheese" });
			Records.Add(new Record { Id = 7, Date = new DateTime(2018, 04, 23), Count = 1, ShopItemName = "Tea" });
			Records.Add(new Record { Id = 9, Date = new DateTime(2018, 04, 30), Count = 1, ShopItemName = "Choclade" });

			var List = from x in Records
								 select new { Date = x.Date, Week = x.Date.WeekNumberString(), Count = x.Count, ShopItemName = x.ShopItemName };

			foreach (var i in List.OrderBy(x => x.ShopItemName).ThenBy(x => x.Week))
			{
				Console.WriteLine($"{i.Date} {i.Week} {i.Count} {i.ShopItemName}");
			}

			Console.WriteLine();

			var Grouped = List
										.GroupBy(x => x.ShopItemName)
										.Select(y =>
										new
										{
											ShopItemName = y.Key,
											Count = y.Sum(x => x.Count)
										});

			foreach (var i in Grouped)
			{
				Console.WriteLine($"{i.ShopItemName} {i.Count}");
			}

			var NewGrouped = Grouped
				.Join(List, g => g.ShopItemName, l => l.ShopItemName,  ( g, l ))
				;


			Console.WriteLine();
			Console.Write("Press any key...");
			Console.ReadKey();
		}
	}

	public class Record
	{
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public string ShopItemName { get; set; }

		public decimal Count { get; set; }
	}

	public static class DateTimeExtensions
	{
		public static string WeekNumberString(this DateTime date)
		{
			DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
			Calendar cal = dfi.Calendar;

			int year = date.Year;
			int week = cal.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

			if (week == 52 && date.Month == 1)
			{
				year--;
			}
			else if (week == 53)
			{
				if (date.Month == 12 && date.DayOfWeek <= DayOfWeek.Wednesday)
				{
					week = 1;
					year++;
				}
				else if (date.Month == 1 && date.DayOfWeek >= DayOfWeek.Thursday)
				{
					year--;
				}
			}

			string weekStr = week.ToString();

			return $"{year}.{("0" + weekStr).Substring(weekStr.Length - 1)}";
		}
	}
}
