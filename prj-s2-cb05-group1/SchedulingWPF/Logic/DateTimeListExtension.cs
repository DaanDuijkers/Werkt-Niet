using System;
using System.Collections.Generic;

namespace SchedulingWPF.Logic
{
	public static class DateTimeListExtension
	{
		public static bool CompareDatesTo(this List<DateTime> thisList, List<DateTime> otherList)
		{
			thisList.Sort();
			otherList.Sort();

			if (thisList.Count == otherList.Count)
			{
				for (int i = 0; i < thisList.Count; i++)
				{
					if (thisList[i].Date != otherList[i].Date)
					{
						return false;
					}
				}
				return true;
			}

			return false;
		}
	}
}