using System.Windows;
using System.Windows.Media;

namespace SchedulingWPF.Logic
{
	internal static class Utility
	{
		private static readonly Size UnlimitedSize = new Size(double.PositiveInfinity, double.PositiveInfinity);

		internal static double ExtractChildWidth(FrameworkElement frameworkElement)
		{
			frameworkElement.Measure(UnlimitedSize);

			if (!double.IsNaN(frameworkElement.DesiredSize.Width) && !double.IsInfinity(frameworkElement.DesiredSize.Width))
			{
				return frameworkElement.DesiredSize.Width;
			}
			return double.NaN;
		}

		internal static targetType FindChildOfSpecificType<targetType>(DependencyObject root) where targetType : DependencyObject
		{
			var childCount = VisualTreeHelper.GetChildrenCount(root);
			for (var i = 0; i < childCount; i++)
			{
				var child = VisualTreeHelper.GetChild(root, i);
				if (child is targetType targetObject)
				{
					return targetObject;
				}
				if ((child = FindChildOfSpecificType<targetType>(child)) != null)
				{
					return (targetType)child;
				}
			}
			return null;
		}
	}
}