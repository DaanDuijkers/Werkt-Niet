using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MediaBazaarModel.Logic
{
	public static class DateTools
	{
		/// <summary>
		/// This returns date of the monday of teh first week of teh year
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		private static DateTime WeekOne(DateTime time)
		{
			var year = time.Year;
			return FirstDateOfWeekISO8601(year, 1);
		}

		public static DateTime WeekOne(int year)
		{
			return FirstDateOfWeekISO8601(year, 1);
		}

		/// <summary>
		/// This calculates the date span of the desired week
		/// </summary>
		/// <param name="currentWeekNumber">number of the week which needs to be returned</param>
		/// <returns>List of dates of the desired week</returns>
		public static List<DateTime> CurrentWeekRange(int currentWeekNumber, int year)
		{
			var weekRange = new List<DateTime>();
			var firstDay = FirstDateOfWeekISO8601(year, currentWeekNumber);
			for (var i = 0; i < 7; i++)
			{
				weekRange.Add(firstDay.AddDays(i));
			}
			return weekRange;
		}

		public static List<DateTime> CurrentWeekRange(DateTime date)
		{
			var weekRange = new List<DateTime>();
			int offset = date.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)date.DayOfWeek - 1;
			for (var i = 0; i < 7; i++)
			{
				weekRange.Add(date.AddDays(i - offset));
			}
			return weekRange;
		}

		/// <summary>
		/// This calculates the week number of the desired date
		/// </summary>
		/// <param name="date">date of which week number we want to calculate</param>
		/// <returns>week number of the desired date</returns>
		public static int DateToWeekNumber(DateTime date)
		{
			//test 31-12-2019
			var weekDates = CurrentWeekRange(date);
			var yearDict = new Dictionary<int, int>();

			foreach (var weekDate in weekDates)
			{
				if (!yearDict.ContainsKey(weekDate.Year))
				{
					yearDict[weekDate.Year] = 1;
				}
				else
				{
					yearDict[weekDate.Year]++;
				}
			}

			var keyList = yearDict.Keys.ToList();

			if (keyList.Count > 1)
			{
				keyList.Sort();
				if (yearDict[keyList[1]] > yearDict[keyList[0]])
				{
					return 1;
				}
			}

			return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
		}

		public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
		{
			var jan1 = new DateTime(year, 1, 1);
			var daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

			// Use first Thursday in January to get first week of the year as
			// it will never be in Week 52/53
			var firstThursday = jan1.AddDays(daysOffset);
			var cal = CultureInfo.CurrentCulture.Calendar;
			var firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

			var weekNum = weekOfYear;
			// As we're adding days to a date in Week 1,
			// we need to subtract 1 in order to get the right date for week #1
			if (firstWeek == 1)
			{
				weekNum -= 1;
			}

			// Using the first Thursday as starting week ensures that we are starting in the right year
			// then we add number of weeks multiplied with days
			var result = firstThursday.AddDays(weekNum * 7);

			// Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
			return result.AddDays(-3);
		}
	}
}