using MediaBazaar.Forms;
using MediaBazaarModel.Logic;
using MediaBazaarModel.sql;
using Serilog;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
	public partial class LoginForm : Form
	{
		private SqlConPerson _sqlConPerson;
		private SqlConPositions _sqlConPosition;
		private PositionsManager _positionsManager;

		public LoginForm()
		{
			InitializeComponent();
			_sqlConPerson = new SqlConPerson();
			_sqlConPosition = new SqlConPositions();
			_positionsManager = new PositionsManager();
		}

		private void btnLogin_Click(object sender, System.EventArgs e)
		{
			//if (txtUsername.Text == "1")
			//{
			//    var hrForm = new HrForm();
			//    Hide();
			//    hrForm.ShowDialog();
			//}
			//else if (txtUsername.Text == "2")
			//{
			//    var salesForm = new ManagerForm();
			//    Hide();
			//    salesForm.ShowDialog();
			//    Log.Debug("Logged in");
			//}
			//Show();
			if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
			{
				try
				{
					Person person;
					Position position;
					int id = _sqlConPerson.Login(txtUsername.Text, txtPassword.Text);
					if (id != -1)
					{
						person = _sqlConPerson.GetIdFromDatabase(id);
						_positionsManager = _sqlConPosition.GetAllFromDatabase();
						position = _positionsManager.FindById(person.PositionId);
						if (position != null)
						{
							switch (position.AccessLevel)
							{
								case "hr":
									HrForm hrForm = new HrForm();
									Log.Information($"User '{person.FirstName} {person.LastName}' has logged in.");
									Hide();
									hrForm.ShowDialog();
									break;

								case "sales":
									break;

								case "shift_manager":
									ManagerForm managerForm = new ManagerForm();
									Log.Information($"User '{person.FirstName} {person.LastName}' has logged in.");
									Hide();
									managerForm.ShowDialog();
									break;

								case "warehouse":
									break;

								default:
									throw new Exception("Position not found!");
							}
							txtUsername.Clear();
							txtPassword.Clear();
							Show();
							txtUsername.Focus();
						}
						else throw new Exception("Position not found!");
					}
					else
					{
						txtPassword.Clear();
						throw new Exception("Incorrect password entered.");
					}
				}
				catch (Exception ex)
				{
					Log.Error(ex.Message);
					MessageBox.Show(ex.Message);
				}
			}
			else MessageBox.Show("Please enter all credentials.");
		}

		private void userTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(null, null);
			}
		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(null, null);
			}
		}

		private void btnManagerForm_Click(object sender, EventArgs e)
		{
			var managerForm = new ManagerForm();
			Log.Information($"Started ManagerForm with button override");
			Hide();
			managerForm.ShowDialog();
			Show();
		}

		private void btnHrForm_Click(object sender, EventArgs e)
		{
			var hrForm = new HrForm();
			Log.Information($"Started HrForm with button override");
			Hide();
			hrForm.ShowDialog();
			Show();
		}

		private void btnPersonalDetailsForm_Click(object sender, EventArgs e)
		{
			var personalDetails = new PersonalDetailsForm(new HrForm(), new PersonManager(), new DepartmentManager(), new PositionsManager());
			Log.Information($"Started HrForm with button override");
			Hide();
			personalDetails.ShowDialog();
			Show();
		}

		private void btnShopFloorForm_Click(object sender, EventArgs e)
		{
			var shopFloorForm = new ShopFloorForm();
			Log.Information($"Started ShopFloorForm with button override");
			Hide();
			shopFloorForm.ShowDialog();
			Show();
		}
	}
}