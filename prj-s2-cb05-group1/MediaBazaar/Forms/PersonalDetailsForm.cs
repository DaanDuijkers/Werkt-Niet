using MediaBazaarModel.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar.Forms
{
	internal partial class PersonalDetailsForm : Form
	{
		private HrForm hr;
		private PersonManager personManager;
		private DepartmentManager departmentManager;
		private PositionsManager positionsManager;

		private List<Department> departments;
		private List<Position> positions;

		private Person edit;

		public PersonalDetailsForm(HrForm hr, PersonManager personManager, DepartmentManager departmentManager, PositionsManager positionsManager)
		{
			InitializeComponent();

			this.hr = hr;
			this.personManager = personManager;
			this.departmentManager = departmentManager;
			this.positionsManager = positionsManager;

			cmbDepartment.DataSource = departmentManager;
			cmbGender.DataSource = Enum.GetValues(typeof(Genders));
			cmbPosition.DataSource = positionsManager;

			this.edit = null;

			txbWorkingHours.Enabled = false;
		}

		public PersonalDetailsForm(HrForm hr, PersonManager personManager, DepartmentManager departmentManager, PositionsManager positionsManager, Person edit)
		{
			InitializeComponent();

			this.hr = hr;
			this.personManager = new PersonManager();
			this.departmentManager = new DepartmentManager();
			this.positionsManager = new PositionsManager();

			cmbDepartment.DataSource = departmentManager;
			cmbGender.DataSource = Enum.GetValues(typeof(Genders));
			cmbPosition.DataSource = positionsManager;

			this.edit = edit;

			cmbPosition.Enabled = false;
			cmbDepartment.Enabled = false;
			txbPay.Enabled = false;

			txbFirstName.Text = edit.FirstName;
			txbLastName.Text = edit.LastName;
			dtpBirthdate.Value = edit.DateOfBirth;
			txbNationality.Text = edit.Nationality;
			txbEmail.Text = edit.Email;
			txbPostal.Text = edit.AddressZipCode;
			txbTown.Text = edit.AddressCity;
			txbAddress.Text = edit.AddressStreet;
			cmbGender.Text = edit.Gender.ToString();
			txbBSN.Text = edit.Bsn.ToString();
			txbPhone.Text = edit.ContactNumber;
			dtpHireDate.Value = edit.DateOfEmployment;
			txbUserName.Text = edit.Login;
			txbPassword.Text = edit.Password;
			txbContactName.Text = edit.IceName;
			txbContactPhone.Text = edit.IceNumber;

			txbWorkingHours.Enabled = false;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (txbFirstName.Text != string.Empty && txbLastName.Text != string.Empty && txbEmail.Text != string.Empty && txbPhone.Text != string.Empty && txbAddress.Text != string.Empty && txbPostal.Text != string.Empty && txbBSN.Text != string.Empty && txbTown.Text != string.Empty && txbUserName.Text != string.Empty && txbPassword.Text != string.Empty && txbConfirmPassword.Text == txbPassword.Text && cmbDepartment.SelectedIndex != -1)
			{
				if (edit == null)
				{
					if (this.personManager.Add(new Person(txbFirstName.Text,
							txbLastName.Text,
							dtpBirthdate.Value,
							txbNationality.Text,
							txbEmail.Text,
							txbPostal.Text,
							txbTown.Text,
							txbAddress.Text,
							dtpHireDate.Value,
							positions[cmbPosition.SelectedIndex]
								.DepartmentId,
							departments[cmbDepartment.SelectedIndex]
								.Id,
							true,
							txbUserName.Text,
							txbPassword.Text,
							(Genders)cmbGender.SelectedItem,
							float.Parse(txbPay.Text),
							Convert.ToInt32(txbBSN.Text),
							txbPhone.Text,
							txbContactName.Text,
							txbContactPhone.Text,
							float.Parse(txbWorkingHours.Text))) ==
						true)
					{
						MessageBox.Show("New person was added!");

						this.Close();
					}
					else
					{
						MessageBox.Show("Error");
					}
				}
				else
				{
					edit.FirstName = txbFirstName.Text;
					edit.LastName = txbLastName.Text;
					edit.DateOfBirth = dtpBirthdate.Value;
					edit.Nationality = txbNationality.Text;
					edit.Email = txbEmail.Text;
					edit.AddressZipCode = txbPostal.Text;
					edit.AddressCity = txbTown.Text;
					edit.AddressStreet = txbAddress.Text;
					edit.Gender = cmbGender.SelectedItem.ToString();
					edit.Bsn = Convert.ToInt32(txbBSN.Text);
					edit.ContactNumber = txbPhone.Text;
					edit.DateOfEmployment = dtpHireDate.Value;
					edit.Login = txbUserName.Text;
					edit.Password = txbPassword.Text;
					edit.IceName = txbContactName.Text;
					edit.IceNumber = txbContactPhone.Text = edit.IceNumber;

					if (this.personManager.Update(edit) == true)
					{
						MessageBox.Show("Person was updated!");

						this.Close();
					}
					else
					{
						MessageBox.Show("Error");
					}
				}
			}
			else
			{
				MessageBox.Show("Please fill in all required data");
			}
		}

		private void cbParttimer_CheckedChanged(object sender, EventArgs e)
		{
			if (cbParttimer.Checked == true)
			{
				txbWorkingHours.Enabled = true;
			}
			else
			{
				txbWorkingHours.Enabled = false;
			}
		}
	}
}