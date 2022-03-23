//  Copyright (c) 2020 Jeff East
//
//  Licensed under the Code Project Open License (CPOL) 1.02

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace SchedulingWPF.Logic
{
	/// <summary>
	/// Sets GridViewColumn widths using the max size of visible column contents + header (if present) at the time
	/// a row is added to the ListView.
	/// </summary>
	public class AutoSizingGridView : GridView
	{
		//  Attached property to track what we've set the width to, per column. If the user overrides
		//  the width, we'll step out of the way and use what they set it to.
		//
		//  Two "magic" values:
		//  - NaN -- not set
		//  - NegInfinity -- disabled

		public static readonly DependencyProperty AutoWidthProperty = DependencyProperty.RegisterAttached(
			"AutoWidth",
			typeof(double),
			typeof(AutoSizingGridView),
			new FrameworkPropertyMetadata(double.NaN));

		private static double GetAutoWidth(GridViewColumn column)
		{
			return (double)column.GetValue(AutoWidthProperty);
		}

		private static void SetAutoWidth(GridViewColumn column, double autoWidth)
		{
			column.SetValue(AutoWidthProperty, autoWidth);
		}

		/// <summary>
		/// Gets or sets a value to enable real-time tracking of header and cell values.
		/// </summary>
		public bool IsValueTrackingEnabled { get; set; }

		private ListView Owner { get; set; }
		private double[] HeaderWidths { get; set; }
		public double MinWidth { get; set; }

		public AutoSizingGridView()
		{
			//  Real-time value tracking is very expensive, so by default, it's turned off

			IsValueTrackingEnabled = false;
			MinWidth = 0;
		}

		public static void ClearAutoWidth(GridViewColumn column)
		{
			SetAutoWidth(column, double.NaN);
		}

		private void ColumnsCollectionChangedHandler(object sender, NotifyCollectionChangedEventArgs e)
		{
			OnColumnsCollectionChanged();
		}

		private void Item_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			if (sender is ListViewItem item)
			{
				item.Loaded -= Item_Loaded;
				item.Unloaded += Item_Unloaded;
				if (Owner == null)
				{
					Owner = ItemsControl.ItemsControlFromItemContainer(item) as ListView;
					Columns.CollectionChanged += ColumnsCollectionChangedHandler;
					if (IsValueTrackingEnabled)
					{
						TrackHeaders();
					}
					ExtractHeaderWidths();
				}
				GridViewRowPresenter presenter = Utility.FindChildOfSpecificType<GridViewRowPresenter>(item);
				if (presenter != null && VisualTreeHelper.GetChildrenCount(presenter) == presenter.Columns.Count && presenter.Columns.Count == Columns.Count)
				{
					if (IsValueTrackingEnabled)
					{
						TrackChildValueChanges(item, presenter);
					}
					double[] columnWidths = ExtractChildWidths(presenter);
					ResolveColumnWidths(MinWidth, columnWidths);
				}
			}
		}

		private void Item_Unloaded(object sender, RoutedEventArgs e)
		{
			if (sender is ListViewItem item)
			{
				item.Unloaded -= Item_Unloaded;
				if (IsValueTrackingEnabled)
				{
					GridViewRowPresenter presenter = Utility.FindChildOfSpecificType<GridViewRowPresenter>(item);
					if (presenter != null)
					{
						UnTrackChildValueChanges(item, presenter);
					}
				}
			}
		}

		protected override void PrepareItem(ListViewItem item)
		{
			item.Loaded += Item_Loaded;
			base.PrepareItem(item);
		}

		private void ResolveColumnWidths(double minWidth, double[] columnWidths = null)
		{
			for (int i = 0; i < Columns.Count; i++)
			{
				if (columnWidths == null || !double.IsNaN(columnWidths[i]))
				{
					//  Check if auto-sizing is disabled

					if (!double.IsNegativeInfinity(GetAutoWidth(Columns[i])))
					{
						if (double.IsNaN(Columns[i].Width) || Columns[i].Width == GetAutoWidth(Columns[i]))
						{
							//  Auto sizing is enabled for this column

							double effectiveColumnWidth = columnWidths == null ? Columns[i].ActualWidth : columnWidths[i];
							double desiredColumnWidth = HeaderWidths.GetUpperBound(0) >= i && !double.IsNaN(HeaderWidths[i]) ? Math.Max(HeaderWidths[i], effectiveColumnWidth) : effectiveColumnWidth;

							//  If the column is shorter than desired, auto-size it

							if (double.IsNaN(Columns[i].Width) || Columns[i].Width < desiredColumnWidth)
							{
								Columns[i].Width = desiredColumnWidth > minWidth ? desiredColumnWidth : minWidth;
								SetAutoWidth(Columns[i], desiredColumnWidth > minWidth ? desiredColumnWidth : minWidth);
							}
						}
						else
						{
							//  The user has overridden the column width, disable auto-sizing for this column

							SetAutoWidth(Columns[i], double.NegativeInfinity);
						}
					}
				}
			}
		}

		private HashSet<GridViewRowPresenter> PendingPresenters = new HashSet<GridViewRowPresenter>();

		internal static double[] ExtractChildWidths(GridViewRowPresenterBase presenter)
		{
			//  We assume the order of the children in the row presenter matches the order of the GridViewColumn objects
			//  in the GridView's Columns collection

			double[] columnWidths = new double[presenter.Columns.Count];

			for (int i = 0; i < presenter.Columns.Count; i++)
			{
				DependencyObject columnContent = VisualTreeHelper.GetChild(presenter, i);
				if (columnContent is FrameworkElement frameworkElement)
				{
					columnWidths[i] = Utility.ExtractChildWidth(frameworkElement);
				}
				else
				{
					//  We have no idea what we're looking at

					columnWidths[i] = double.NaN;
				}
			}

			return columnWidths;
		}

		internal void TrackChildValueChanges(ListViewItem listViewItem, GridViewRowPresenterBase presenter)
		{
			HashSet<INotifyPropertyChanged> monitoredItems = new HashSet<INotifyPropertyChanged>();
			int childCount = VisualTreeHelper.GetChildrenCount(presenter);
			for (int i = 0; i < childCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(presenter, i);
				if (child is FrameworkElement frameworkElement)
				{
					if (i < Columns.Count && Columns[i].DisplayMemberBinding is Binding binding && binding.NotifyOnTargetUpdated)
					{
						frameworkElement.TargetUpdated += ListViewItem_TargetUpdated;
					}
					else if (child is TextBlock textBlock)
					{
						BindingExpression be = BindingOperations.GetBindingExpression(textBlock, TextBlock.TextProperty);
						if (be != null && be.ResolvedSource is INotifyPropertyChanged monitorableObject && !monitoredItems.Contains(monitorableObject))
						{
							monitorableObject.PropertyChanged += ListViewItem_TextChanged;
							monitoredItems.Add(monitorableObject);
						}
					}
				}
			}
		}

		private void ListViewItem_TargetUpdated(object sender, DataTransferEventArgs e)
		{
			GridViewRowPresenter presenter = (sender as FrameworkElement)?.Parent as GridViewRowPresenter;
			if (presenter != null)
			{
				SchedulePendingValueChange(presenter);
			}
		}

		private void ListViewItem_TextChanged(object sender, PropertyChangedEventArgs e)
		{
			ListViewItem item = Owner.ItemContainerGenerator.ContainerFromItem(sender) as ListViewItem;
			if (item != null)
			{
				GridViewRowPresenter presenter = Utility.FindChildOfSpecificType<GridViewRowPresenter>(item);
				if (presenter != null)
				{
					SchedulePendingValueChange(presenter);
				}
			}
		}

		private void ProcessPendingValueChanges()
		{
			lock (PendingPresenters)
			{
				if (Owner.IsLoaded)
				{
					foreach (GridViewRowPresenter presenter in PendingPresenters)
					{
						double[] columnWidths = ExtractChildWidths(presenter);
						ResolveColumnWidths(MinWidth, columnWidths);
					}
				}

				PendingPresenters.Clear();
			}
		}

		private void SchedulePendingValueChange(GridViewRowPresenter presenter)
		{
			lock (PendingPresenters)
			{
				if (!PendingPresenters.Contains(presenter))
				{
					PendingPresenters.Add(presenter);
					if (PendingPresenters.Count == 1)
					{
						Dispatcher.BeginInvoke((Action)delegate
						{
							ProcessPendingValueChanges();
						}, System.Windows.Threading.DispatcherPriority.Normal);
					}
				}
			}
		}

		internal void UnTrackChildValueChanges(ListViewItem listViewItem, GridViewRowPresenterBase presenter)
		{
			HashSet<INotifyPropertyChanged> monitoredItems = new HashSet<INotifyPropertyChanged>();
			int childCount = VisualTreeHelper.GetChildrenCount(presenter);
			for (int i = 0; i < childCount; i++)
			{
				DependencyObject child = VisualTreeHelper.GetChild(presenter, i);
				if (child is FrameworkElement frameworkElement)
				{
					if (i < Columns.Count && Columns[i].DisplayMemberBinding is Binding binding && binding.NotifyOnTargetUpdated)
					{
						frameworkElement.TargetUpdated -= ListViewItem_TargetUpdated;
					}
					else if (child is TextBlock textBlock)
					{
						BindingExpression be = BindingOperations.GetBindingExpression(textBlock, TextBlock.TextProperty);
						if (be != null && be.ResolvedSource is INotifyPropertyChanged monitorableObject && !monitoredItems.Contains(monitorableObject))
						{
							monitorableObject.PropertyChanged -= ListViewItem_TextChanged;
							monitoredItems.Add(monitorableObject);
						}
					}
				}
			}
		}

		private void ColumnHeaderPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Header")
			{
				ExtractHeaderWidths();
				ResolveColumnWidths(MinWidth);
			}
		}

		private void ExtractHeaderWidths()
		{
			HeaderWidths = new double[Columns.Count];

			//  The default header width is unknown

			for (int i = 0; i < Columns.Count; i++)
			{
				HeaderWidths[i] = double.NaN;
			}

			GridViewHeaderRowPresenter presenter = Utility.FindChildOfSpecificType<GridViewHeaderRowPresenter>(Owner);
			if (presenter != null)
			{
				//  Scan the presenters children, and try to extract the header widths

				int childCount = VisualTreeHelper.GetChildrenCount(presenter);
				for (int i = 0; i < childCount; i++)
				{
					DependencyObject child = VisualTreeHelper.GetChild(presenter, i);
					if (child is GridViewColumnHeader columnHeader && columnHeader.Column != null)
					{
						int columnIndex = Columns.IndexOf(columnHeader.Column);
						if (columnIndex >= HeaderWidths.GetLowerBound(0) && columnIndex <= HeaderWidths.GetUpperBound(0))
						{
							HeaderWidths[columnIndex] = Utility.ExtractChildWidth(columnHeader);
						}
					}
				}
			}
		}

		private void OnColumnsCollectionChanged()
		{
			ExtractHeaderWidths();
			ResolveColumnWidths(MinWidth);
		}

		private void TrackHeaders()
		{
			foreach (GridViewColumn column in Columns)
			{
				(column as INotifyPropertyChanged).PropertyChanged += ColumnHeaderPropertyChangedHandler;
			}
		}
	}
}