using MediaBazaarModel.Logic;
using SchedulingWPF;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MediaBazaar.Forms
{
	public partial class ManagerForm : Form
	{
		private ElementHost ctrlHost;
		private SchedulingWPF.ShiftSchedulerUserControl schedulerUserControl;
		private DepartmentManager departmentManager;

		public ManagerForm()
		{
			InitializeComponent();
			departmentManager = new DepartmentManager();
			departmentManager.GetAllFromDatabase();
		}

		private void SalesForm_Load(object sender, System.EventArgs e)
		{
			var i = 0;
			foreach (var department in departmentManager)
			{
				CreateTabs(department, i);
				i++;
			}

			//var dept = new Department(-1, "Overview");
			//CreateTabs(dept, i);

			//ctrlHost = new ElementHost { Dock = DockStyle.Fill };
			//wpfControlPanel.Controls.Add(ctrlHost);
			//schedulerUserControl = new ShiftSchedulerUserControl();
			//schedulerUserControl.DepartmentId = 1;
			//schedulerUserControl.InitializeComponent();
			//ctrlHost.Child = schedulerUserControl;
		}

		private void CreateTabs(Department department, int i)
		{
			tabControlDepartments.TabPages.Add(department.Name);
			var panel = new Panel()
			{
				Dock = DockStyle.Fill
			};
			tabControlDepartments.TabPages[i].Controls.Add(panel);
			ctrlHost = new ElementHost { Dock = DockStyle.Fill };
			panel.Controls.Add(ctrlHost);
			schedulerUserControl = new ShiftSchedulerUserControl();
			schedulerUserControl.SetDepartmentId(department.Id);
			schedulerUserControl.InitializeComponent();
			ctrlHost.Child = schedulerUserControl;
		}
	}
}