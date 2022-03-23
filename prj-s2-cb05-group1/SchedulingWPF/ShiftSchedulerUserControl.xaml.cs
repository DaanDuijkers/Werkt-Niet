using MediaBazaarModel.Logic;
using MediaBazaarModel.sql;
using SchedulingWPF.Logic;
using Serilog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchedulingWPF
{
	/// <summary>
	/// Interaction logic for ShiftSchedulerUserControl.xaml
	/// </summary>
	public partial class ShiftSchedulerUserControl : UserControl
	{
		private SqlConPerson personCon;
		private List<Grid> grids = new List<Grid>();
		private List<AutoSizingGridView> gridViews = new List<AutoSizingGridView>();
		private List<ListViewExtend> listViews = new List<ListViewExtend>();
		private ShiftManager shiftManager = new ShiftManager();
		private PersonManager personManager = new PersonManager();
		private WeekNumber weekNumber;
		private SqlConShifts sqlConShifts = new SqlConShifts();
		private string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
		private ShiftTypes[] shiftTypes = (ShiftTypes[])Enum.GetValues(typeof(ShiftTypes));
		private int DepartmentId;

		public ShiftSchedulerUserControl()
		{
			InitializeComponent();
		}

		#region Initialization

		public void SetDepartmentId(int departmentId)
		{
			DepartmentId = departmentId;
			DrawGrid(shiftTypes);
			listViews[0].SizeChanged += LV_SizeChanged;
			Initialize();

			if (departmentId == -1)
			{
				foreach (var listView in listViews)
				{
					listView.Drop -= ListViewOnDrop;
					listView.KeyDown -= ListView_KeyDown;
				}

				lbEmployees.MouseMove -= lbEmployees_MouseMove;
				btnAccept.IsEnabled = false;
				btnAccept.IsEnabled = false;
			}
			else
			{
				CreateContextMenu(lbEmployees);
			}
		}

		/// <summary>
		/// This method selects date on the calendar creates a weekNumber class and assigns events for changing value of the weeknumber.number,
		/// then changes the date again to kick start the event, not much to see here
		/// </summary>
		private void Initialize()
		{
			DataConnectionInit();
			WeekCalendar.SelectedDate = DateTime.Today;
			weekNumber = new WeekNumber(DateTime.Today);
			weekNumber.PropertyChanged += WeekNumber_PropertyChanged;
			WeekCalendar.SelectedDatesChanged += SelectedDateChange;
			weekNumber.DateToWeekNumber(DateTime.Today);
			//WeekCalendar.BlackoutDates.AddDatesInPast();
		}

		/// <summary>
		/// This actually draws the grids, labels and listviews, it has to be flexible in case the change of teh shift division
		/// </summary>
		/// <param name="shiftTypes"></param>
		private void DrawGrid(ShiftTypes[] shiftTypes)
		{
			//Creates the grid on which everything will be created
			var gridShifts = new Grid();
			for (var index = 0; index < shiftTypes.Length; index++)
			{
				//Creates two grid rows one for label and second for the listviews
				var firstRow = new RowDefinition { Height = new GridLength(30) };
				var secondRow = new RowDefinition();
				gridShifts.RowDefinitions.Add(firstRow);
				gridShifts.RowDefinitions.Add(secondRow);
			}

			var i = 0;

			//iterates through available shift division which is dependent on ShiftTypes Enum
			foreach (var shiftType in shiftTypes)
			{
				//Creates label
				var label = new Label()
				{
					Content = shiftType.ToString(),
					Height = 30,
					Width = 200,
					Margin = new Thickness(5, 0, 0, 0),
					HorizontalAlignment = HorizontalAlignment.Left,
					VerticalAlignment = VerticalAlignment.Top
				};
				//Adds it to the grid
				Grid.SetRow(label, i);
				gridShifts.Children.Add(label);

				//Creates gridview for listViews, each listview is in teh separate grid column for easier formatting
				var gridShiftsWeekView = new Grid()
				{
					Margin = new Thickness(5, 0, 10, 0)
				};
				//Creates one listview per day per shifttype
				foreach (var s in daysOfTheWeek)
				{
					var column = new ColumnDefinition()
					{
						Width = new GridLength(1, GridUnitType.Star)
					};
					gridShiftsWeekView.ColumnDefinitions.Add(column);

					//Actually creates the listview itself, has to allow drag and dropping, assigns shift type and proper DayOfWeek,
					//DayOfWeek Enum itself cannot be used for iterating because of the order of teh weekdays, Sunday is first day of the week
					var listView = new ListViewExtend()
					{
						Name = s + shiftType + "ListView",
						AllowDrop = true,
						ShiftType = shiftType,
						DayOfWeekType = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), s)
					};
					//Added event method for dropping
					listView.Drop += ListViewOnDrop;
					listView.KeyDown += ListView_KeyDown;
					//Custom GidView had to be used, because regular gridView does not have autosize option for width while adding items
					var gridView = new AutoSizingGridView();
					listView.View = gridView;
					//Added Headers for listviews
					gridView.Columns.Add(new GridViewColumn()
					{
						Header = s,
					});
					//Adding gridviews and listviews to list for later access
					listViews.Add(listView);
					gridViews.Add(gridView);
					Grid.SetColumn(listView, gridShiftsWeekView.ColumnDefinitions.Count - 1);
					gridShiftsWeekView.Children.Add(listView);
					//This stuff below is for adjusting headers to be horizontally aligned to left
					Style headerStyle = new Style()
					{
						TargetType = typeof(GridViewColumnHeader)
					};
					headerStyle.Setters.Add(new Setter(HorizontalContentAlignmentProperty, HorizontalAlignment.Left));
					listView.Resources.Add(typeof(GridViewColumnHeader), headerStyle);
				}
				//Everything below if for adding stuff to correct grids
				Grid.SetRow(gridShiftsWeekView, i + 1);
				gridShifts.Children.Add(gridShiftsWeekView);
				grids.Add(gridShiftsWeekView);
				i += 2;
			}
			Grid.SetColumn(gridShifts, 1);
			MainGrid.Children.Add(gridShifts);
		}

		private void DataConnectionInit()
		{
			personManager.GetAllFromDatabase();
			lbEmployees.ItemsSource = personManager.FindAllActivePersonsFromDepartment(DepartmentId);
			shiftManager = sqlConShifts.GetAllFromDatabase();
			shiftManager.GetPersonsFromIds(personManager);
			AdjustGridViewWidths();
		}

		#endregion Initialization

		#region Event Handlers

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			lbEmployees.SelectedIndex = -1;
		}

		private void Menu_Click(object sender, RoutedEventArgs e)
		{
			var item = e.Source as MenuItem;
			var selectedItems = lbEmployees.SelectedItems;

			var menuParameters = item.Name.Split('X');

			AddToShifts(selectedItems, menuParameters[0], menuParameters[1]);
		}

		/// <summary>
		/// This event method changes teh value of the label with week number in it and checks if all the dates in the selected week are selected,
		/// unfortunately a custom comparer was needed.
		/// Second part with the loop assigns new dates to custom listviews, for proper PersonManager handling, checks if the dates have the same weekday
		/// It assigns proper shifts to proper listviews
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WeekNumber_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Number")
			{
				lblWeekNumber.Content = weekNumber.Number;
				var week = weekNumber.CurrentWeekRange();
				var week2 = WeekCalendar.SelectedDates.ToList();
				if (!week2.CompareDatesTo(week))
				{
					WeekCalendar.SelectedDates.AddRange(week[0], week[6]);
				}

				foreach (var listView in listViews)
				{
					foreach (var date in week)
					{
						if (listView.DayOfWeekType == date.DayOfWeek)
						{
							listView.Date = date;
						}
					}
					//TODO fix the department for this class
					var shift = shiftManager.FindShift(listView.Date, listView.ShiftType, DepartmentId);
					if (shift != null)
					{
						listView.ItemsSource = shift.ShiftWorkers;
						listView.ItemsSourceReference = shift.ShiftWorkers;
					}
					else
					{
						listView.ItemsSource = null;
						listView.ItemsSourceReference = null;
					}
				}
			}
		}

		private void ListView_KeyDown(object sender, KeyEventArgs e)
		{
			var lv = (ListViewExtend)sender;
			if (e.Key == Key.Delete)
			{
				var selectedItems = (Person)lv.SelectedItem;
				lv.ItemsSourceReference.Remove(selectedItems);
				Log.Information($"{selectedItems} has been removed");
			}
		}

		private void SelectedDateChange(object sender, SelectionChangedEventArgs e)
		{
			var selectedDate = WeekCalendar.SelectedDates[0];
			//This is for automatic date following, otherwise when the date is changed with buttons the calendar won't follow it
			WeekCalendar.DisplayDate = selectedDate;
			//Setting correct week number, which triggers the event
			weekNumber.DateToWeekNumber(selectedDate);
		}

		/// <summary>
		/// Part of Drag and Drop functionality, dragging from actually
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lbEmployees_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				//var data = lbEmployees.SelectedItems;
				DataObject data = new DataObject();
				data.SetData("IList", lbEmployees.SelectedItems);

				DragDrop.DoDragDrop(this, data, DragDropEffects.Copy);
			}
		}

		/// <summary>
		/// Dropping functionality, assigns new Shift if not present
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ListViewOnDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent("IList"))
			{
				var selectedItems = e.Data.GetData("IList") as IList;
				var listView = sender as ListViewExtend;
				AddUsersOnDrop(listView, selectedItems);
			}

			e.Handled = true;
			lbEmployees.SelectedIndex = -1;
		}

		private void LV_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			AdjustGridViewWidths();
		}

		private void btnWeekBack_Click(object sender, RoutedEventArgs e)
		{
			weekNumber.Decrease();
		}

		private void btnWeekForward_Click(object sender, RoutedEventArgs e)
		{
			weekNumber.Increase();
		}

		private void btnAccept_Click(object sender, RoutedEventArgs e)
		{
			if (shiftManager.UpdateAll())
			{
				MessageBox.Show("All changes have been saved successfully!", "Success", MessageBoxButton.OK,
					MessageBoxImage.Information);
			}
		}

		private void btnReject_Click(object sender, RoutedEventArgs e)
		{
			DataConnectionInit();
			var week = weekNumber.CurrentWeekRange();
			var week2 = WeekCalendar.SelectedDates.ToList();
			if (!week2.CompareDatesTo(week))
			{
				WeekCalendar.SelectedDates.AddRange(week[0], week[6]);
			}

			foreach (var listView in listViews)
			{
				foreach (var date in week)
				{
					if (listView.DayOfWeekType == date.DayOfWeek)
					{
						listView.Date = date;
					}
				}
				//TODO fix the department for this class
				var shift = shiftManager.FindShift(listView.Date, listView.ShiftType, DepartmentId);
				if (shift != null)
				{
					listView.ItemsSource = shift.ShiftWorkers;
					listView.ItemsSourceReference = shift.ShiftWorkers;
				}
				else
				{
					listView.ItemsSource = null;
					listView.ItemsSourceReference = null;
				}
			}
		}

		#endregion Event Handlers

		#region Event Handlers Extenstion Methods

		private void CreateContextMenu(ListBoxExtend lb)
		{
			var cm = new ContextMenu();
			var week = new MenuItem();
			week.Header = "Assign selected to week shifts:";
			var weekend = new MenuItem();
			weekend.Header = "Assign selected to weekend shifts:";
			var allWeek = new MenuItem();
			var allWeekend = new MenuItem();
			allWeek.Header = "All";
			allWeek.Name = "WeekXAll";
			allWeekend.Header = "All";
			allWeekend.Name = "WeekendXAll";
			allWeek.Click += Menu_Click;
			allWeekend.Click += Menu_Click;

			//allWeek.Command = AddToShifts()
			weekend.Items.Add(allWeekend);
			week.Items.Add(allWeek);
			var clear = new MenuItem();
			clear.Header = "Clear Selection";
			clear.Click += Clear_Click;
			cm.Items.Add(clear);

			foreach (var shift in (String[])Enum.GetNames(typeof(ShiftTypes)))
			{
				var menu = new MenuItem();
				menu.Name = "WeekX" + shift;
				menu.Header = shift;
				menu.Click += Menu_Click;
				week.Items.Add(menu);
				var menu2 = new MenuItem();
				menu2.Name = "WeekendX" + shift;
				menu2.Header = shift;
				menu2.Click += Menu_Click;
				weekend.Items.Add(menu2);
			}
			cm.Items.Add(week);
			cm.Items.Add(weekend);
			lb.ContextMenu = cm;
		}

		private void AddToShifts(IList selectedItems, string weekOrWeekend, string shiftType)
		{
			if (weekOrWeekend == "Week")
			{
				if (shiftType == "All")
				{
					foreach (var listView in listViews)
					{
						if (listView.DayOfWeekType != DayOfWeek.Saturday && listView.DayOfWeekType != DayOfWeek.Sunday)
						{
							AddUsersOnDrop(listView, selectedItems);
						}
					}
				}
				else
				{
					foreach (var listView in listViews)
					{
						if (listView.DayOfWeekType != DayOfWeek.Saturday && listView.DayOfWeekType != DayOfWeek.Sunday && (listView.ShiftType == (ShiftTypes)Enum.Parse(typeof(ShiftTypes), shiftType)))
						{
							AddUsersOnDrop(listView, selectedItems);
						}
					}
				}
			}
			else
			{
				if (shiftType == "All")
				{
					foreach (var listView in listViews)
					{
						if (listView.DayOfWeekType == DayOfWeek.Saturday || listView.DayOfWeekType == DayOfWeek.Sunday)
						{
							AddUsersOnDrop(listView, selectedItems);
						}
					}
				}
				else
				{
					foreach (var listView in listViews)
					{
						if ((listView.DayOfWeekType == DayOfWeek.Saturday || listView.DayOfWeekType == DayOfWeek.Sunday) && (listView.ShiftType == (ShiftTypes)Enum.Parse(typeof(ShiftTypes), shiftType)))
						{
							AddUsersOnDrop(listView, selectedItems);
						}
					}
				}
			}
		}

		/// <summary>
		/// this adjusts the width of teh gridviews or at least it's suppose to, stopped working at some point, it takes too much time to fix this, maybe I will fix it later
		/// </summary>
		private void AdjustGridViewWidths()
		{
			for (int i = 0; i < listViews.Count; i++)
			{
				gridViews[i].MinWidth = listViews[i].ActualWidth - 10;
			}
		}

		private void AddUsersOnDrop(ListViewExtend listView, IList selectedItems)
		{
			if (listView.ItemsSourceReference == null)
			{
				//TODO department handling
				var shift = new Shift(listView.Date, listView.ShiftType, DepartmentId);
				shiftManager.Add(shift);
				var personManager = new PersonManager();
				shift.ShiftWorkers = personManager;
				foreach (Person person in selectedItems)
				{
					personManager.Add(person);
				}

				listView.ItemsSource = personManager;
				listView.ItemsSourceReference = personManager;
			}
			else
			{
				var source = listView.ItemsSourceReference;
				foreach (Person person in selectedItems)
				{
					source.Add(person);
				}
			}
		}

		#endregion Event Handlers Extenstion Methods
	}
}