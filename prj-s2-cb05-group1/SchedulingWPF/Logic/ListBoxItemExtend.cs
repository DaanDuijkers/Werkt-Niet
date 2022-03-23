using System.Windows.Controls;
using System.Windows.Input;

namespace SchedulingWPF.Logic
{
	public class ListBoxItemExtend : ListBoxItem
	{
		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
		{
			if (IsSelected)
				e.Handled = true;
			base.OnMouseLeftButtonDown(e);
		}

		protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			if (!IsSelected)
				base.OnMouseLeftButtonDown(e);
			base.OnMouseLeftButtonUp(e);
		}

		protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
		{
			if (IsSelected)
				e.Handled = true;
			base.OnMouseRightButtonDown(e);
		}

		protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
		{
			if (!IsSelected)
				base.OnMouseRightButtonUp(e);
			base.OnMouseRightButtonUp(e);
		}
	}
}