using MediaBazaarModel.Logic;
using System;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
	public partial class HrForm : Form
	{
		private PersonManager _personManager;
		private DepartmentManager _departmentManager;
		private PositionsManager _positionsManager;

		public HrForm()
		{
			InitializeComponent();
			this.CenterToScreen();
			_personManager = new PersonManager();
			_departmentManager = new DepartmentManager();
			_positionsManager = new PositionsManager();

			lvEmployees.FullRowSelect = true;
			lvEmployees.AllowColumnReorder = false;
			lvEmployees.GridLines = true;
			for (int i = 0; i < 5; i++)
			{
				lvEmployees.Columns[i].Width = -1;
			}

			_personManager.GetAllFromDatabase();
			_departmentManager.GetAllFromDatabase();
			_positionsManager.GetAllFromDatabase();
			PopulateListview();

			foreach (Department deparment in _departmentManager)
			{
				cbxFilterDepartment.Items.Add(deparment.Name);
			}
			foreach (Position position in _positionsManager)
			{
				cbxFilterPosition.Items.Add(position.PositionName);
			}
		}

		public ListViewItem ListViewItem(Person person)
		{
			string[] arr = new string[5];
			arr[0] = person.Id.ToString();
			arr[1] = person.FirstName;
			arr[2] = person.LastName;
			foreach (Department department in _departmentManager)
			{
				if (department.Id == person.DepartmentId)
				{
					arr[3] = department.Name;
				}
			}
			foreach (Position position in _positionsManager)
			{
				if (position.Id == person.PositionId)
				{
					arr[4] = position.PositionName;
				}
			}

			return new ListViewItem(arr);
		}

		private void PopulateListview()
		{
			lvEmployees.Items.Clear();
			foreach (Person person in _personManager)
			{
				if (person.IsActive == true)
				{
					lvEmployees.Items.Add(ListViewItem(person));
				}
			}
		}

		private void btnSearchEmployee_Click(object sender, EventArgs e)
		{
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text != string.Empty)
			{
				lvEmployees.Items.Clear();
				cbxFilterDepartment.SelectedIndex = -1;
				cbxFilterPosition.SelectedIndex = -1;
				foreach (Person person in _personManager)
				{
					if (person.IsActive == true)
					{
						if (person.Id.ToString().Contains(txtSearch.Text) || person.FirstName.IndexOf(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1 || person.LastName.IndexOf(txtSearch.Text, StringComparison.CurrentCultureIgnoreCase) != -1)
						{
							lvEmployees.Items.Add(ListViewItem(person));
						}
					}
				}
			}
			else PopulateListview();
		}

		private void cbxFilterDepartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxFilterDepartment.SelectedIndex != -1)
			{
				cbxFilterPosition.SelectedIndex = -1;
				txtSearch.Clear();
				lvEmployees.Items.Clear();
				foreach (Person person in _personManager)
				{
					if (person.IsActive == true)
					{
						foreach (Department department in _departmentManager)
						{
							if (department.Name == cbxFilterDepartment.SelectedItem.ToString())
							{
								if (department.Id == person.DepartmentId)
								{
									lvEmployees.Items.Add(ListViewItem(person));
								}
							}
						}
					}
				}
			}
		}

		private void cbxFilterPosition_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxFilterPosition.SelectedIndex != -1)
			{
				cbxFilterDepartment.SelectedIndex = -1;
				txtSearch.Clear();
				lvEmployees.Items.Clear();
				foreach (Person person in _personManager)
				{
					if (person.IsActive == true)
					{
						foreach (Position position in _positionsManager)
						{
							if (position.PositionName == cbxFilterPosition.SelectedItem.ToString())
							{
								if (position.Id == person.PositionId)
								{
									lvEmployees.Items.Add(ListViewItem(person));
								}
							}
						}
					}
				}
			}
		}

		private void btnViewAllEmployees_Click(object sender, EventArgs e)
		{
			PopulateListview();
			cbxFilterDepartment.SelectedIndex = -1;
			cbxFilterPosition.SelectedIndex = -1;
			txtSearch.Clear();
		}
	}
}