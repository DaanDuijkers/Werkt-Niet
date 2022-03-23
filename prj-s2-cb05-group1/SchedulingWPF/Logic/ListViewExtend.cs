using MediaBazaarModel.Logic;
using System;
using System.Windows.Controls;

namespace SchedulingWPF.Logic
{
	public class ListViewExtend : ListView
	{
		public PersonManager ItemsSourceReference { get; set; }
		public ShiftTypes ShiftType { get; set; }
		public DateTime Date { get; set; }
		public DayOfWeek DayOfWeekType { get; set; }
	}
}