using SchedulingWPF;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MediaBazaar.Forms
{
	public partial class ShopFloorForm : Form
	{
		private ElementHost ctrlHost;
		private SchedulingWPF.ShopFloorShopUserControl shopUserControl;

		public ShopFloorForm()
		{
			InitializeComponent();
			Init();
		}

		public void Init()
		{
			ctrlHost = new ElementHost { Dock = DockStyle.Fill };
			panel.Controls.Add(ctrlHost);
			shopUserControl = new ShopFloorShopUserControl();
			shopUserControl.InitializeComponent();
			ctrlHost.Child = shopUserControl;
		}
	}
}