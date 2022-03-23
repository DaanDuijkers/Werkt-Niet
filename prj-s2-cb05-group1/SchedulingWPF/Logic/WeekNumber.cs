using MediaBazaarModel.Logic;
using SchedulingWPF.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SchedulingWPF.Logic
{
	public class WeekNumber : INotifyPropertyChanged
	{
		private int _number;
		private int _year;

		public int Number
		{
			get => _number;
			set
			{
				_number = value;
				OnPropertyChanged(nameof(Number));
			}
		}

		public int Year
		{
			get => _year;
			set
			{
				_year = value;
				OnPropertyChanged(nameof(Year));
			}
		}

		public WeekNumber(int weekNumber, int year)
		{
			Number = weekNumber;
			Year = year;
		}

		public WeekNumber(DateTime date)
		{
			DateToWeekNumber(date);
		}

		public void DateToWeekNumber(DateTime date)
		{
			Year = date.Year;
			Number = DateTools.DateToWeekNumber(date);
		}

		public void Increase()
		{
			Number++;
			//MessageBox.Show($"Number: {Number}, Year: {Year}");
		}

		public void Decrease()
		{
			Number--;
			//MessageBox.Show($"Number: {Number}, Year: {Year}");
		}

		public List<DateTime> CurrentWeekRange()
		{
			return DateTools.CurrentWeekRange(Number, Year);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}