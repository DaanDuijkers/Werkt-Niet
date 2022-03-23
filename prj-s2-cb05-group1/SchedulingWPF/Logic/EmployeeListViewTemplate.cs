using SchedulingWPF.Annotations;
using System;
using System.ComponentModel;
using System.Windows.Media;

namespace SchedulingWPF.Logic
{
	public class EmployeeListViewTemplate : INotifyPropertyChanged
	{
		private SolidColorBrush color;

		public SolidColorBrush Status
		{
			get => color;
			set
			{
				color = value;
				OnPropertyChanged("ColorChanged");
			}
		}

		public string Name { get; set; }
		public int Id { get; set; }
		public string DayOfTheWeek { get; set; }

		public EmployeeListViewTemplate(SolidColorBrush status, string nameAndId, string dayOfTheWeek)
		{
			Status = status;
			var text = nameAndId.Split(',');
			Name = text[0].Trim();
			Id = Convert.ToInt32(text[1].Trim());
			DayOfTheWeek = dayOfTheWeek;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string info)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
		}

		public override string ToString()
		{
			return $"{Name}, {Id}";
		}
	}
}