using System.Windows;
using System.Windows.Controls;

namespace SchedulingWPF
{
	/// <summary>
	/// Interaction logic for ShopFloorShopUserControl.xaml
	/// </summary>
	public partial class ShopFloorShopUserControl : UserControl
	{
		public ShopFloorShopUserControl()
		{
			InitializeComponent();
		}

		private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
		{
			MiddleButtonsVisible(true);
		}

		public void MiddleButtonsVisible(bool visible)
		{
			if (visible)
			{
				btnAddProduct.Visibility = Visibility.Visible;
				btnRemoveProduct.Visibility = Visibility.Visible;
				btnCompleteOrder.Visibility = Visibility.Visible;
				btnCancelOrder.Visibility = Visibility.Visible;
				lvMiddle.Margin = new Thickness(5, 5, 5, 80);
				lblDetails.Visibility = Visibility.Hidden;
			}
			else
			{
				btnAddProduct.Visibility = Visibility.Hidden;
				btnRemoveProduct.Visibility = Visibility.Hidden;
				btnCompleteOrder.Visibility = Visibility.Hidden;
				btnCancelOrder.Visibility = Visibility.Hidden;
				lvMiddle.Margin = new Thickness(5, 5, 5, 10);
				lblDetails.Visibility = Visibility.Visible;
			}
		}

		private void btnShowOrder_Click(object sender, RoutedEventArgs e)
		{
			MiddleButtonsVisible(false);
		}
	}
}