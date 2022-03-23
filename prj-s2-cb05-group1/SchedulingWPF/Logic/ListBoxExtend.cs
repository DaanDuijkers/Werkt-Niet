using System.Windows;
using System.Windows.Controls;

namespace SchedulingWPF.Logic
{
	public class ListBoxExtend : ListBox
	{
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new ListBoxItemExtend();
		}
	}
}