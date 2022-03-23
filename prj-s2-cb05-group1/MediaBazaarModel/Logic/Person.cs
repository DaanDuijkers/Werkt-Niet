using System;
using System.Text.RegularExpressions;

namespace MediaBazaarModel.Logic
{
	public class Person : HasId
	{
		#region private props

		private string _email;
		private string _zipCode;
		private int _bsn;
		private string _iceNumber;
		private string _contactNumber;
		private string _password;
		private double _salary;
		private double _partTimeFactor;

		#endregion private props

		#region props

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }

		public string Email
		{
			get => _email;
			set
			{
				string emailRegex = "@[a-z0-9]{1,}\\.[a-z]{2,}";
				if (Regex.IsMatch(value.ToLower(), emailRegex))
				{
					_email = value.ToLower();
				}
			}
		}

		public string AddressZipCode
		{
			get => _zipCode;
			set
			{
				string zipCodeRegex = @"\b[0-9]{4}[A-Z]{2}\b";
				if (Regex.IsMatch(value.ToUpper(), zipCodeRegex))
				{
					_zipCode = value.ToUpper();
				}
			}
		}

		public int Bsn
		{
			get => _bsn;
			set
			{
				string bsnRegex = @"\b[0-9]{9}\b";
				if (Regex.IsMatch(value.ToString(), bsnRegex))
				{
					_bsn = value;
				}
			}
		}

		public string IceNumber
		{
			get => _iceNumber;
			set
			{
				string number = value;
				number = number.Replace(" ", string.Empty);
				string iceNumberRegex = @"\b[0-9]{7,15}\b";
				if (Regex.IsMatch(number, iceNumberRegex))
				{
					_iceNumber = number;
				}
			}
		}

		public string ContactNumber
		{
			get => _contactNumber;
			set
			{
				string number = value;
				number = number.Replace(" ", string.Empty);
				string contactNumberRegex = @"\b[0-9]{7,15}\b";
				if (Regex.IsMatch(number, contactNumberRegex))
				{
					_contactNumber = number;
				}
			}
		}

		public string Password
		{
			get => _password;
			set
			{
				string passwordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&#]{8,}$";
				if (Regex.IsMatch(value, passwordRegex))
				{
					_password = BCrypt.Net.BCrypt.HashPassword(value);
				}
			}
		}

		public double Salary
		{
			get => _salary;
			set
			{
				if (value >= 0)
				{
					_salary = value;
				}
			}
		}

		public double PartTimeFactor
		{
			get => _partTimeFactor;
			set
			{
				if (value > 0 && value <= 100)
				{
					_partTimeFactor = value;
				}
			}
		}

		public string AddressCity { get; set; }
		public string AddressStreet { get; set; }
		public DateTime DateOfEmployment { get; set; }
		public string Nationality { get; set; }
		public int PositionId { get; set; }
		public int DepartmentId { get; set; }
		public bool IsActive { get; set; }
		public string Login { get; set; }
		public string Gender { get; set; }
		public string IceName { get; set; }

		/// <summary>
		/// Constructor for creating new Person
		/// </summary>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="dateOfBirth"></param>
		/// <param name="nationality"></param>
		/// <param name="email"></param>
		/// <param name="addressZipCode"></param>
		/// <param name="addressCity"></param>
		/// <param name="addressStreet"></param>
		/// <param name="dateOfEmployment"></param>
		/// <param name="positionId"></param>
		/// <param name="departmentId"></param>
		/// <param name="isActive"></param>
		/// <param name="login"></param>
		/// <param name="password"></param>
		/// <param name="gender"></param>
		/// <param name="salary"></param>
		/// <param name="bsn"></param>
		/// <param name="contactNumber"></param>
		/// <param name="iceName"></param>
		/// <param name="iceNumber"></param>
		/// <param name="partTimeFactor"></param>
		public Person(
			string firstName,
			string lastName,
			DateTime dateOfBirth,
			string nationality,
			string email,
			string addressZipCode,
			string addressCity,
			string addressStreet,
			DateTime dateOfEmployment,
			int positionId,
			int departmentId,
			bool isActive,
			string login,
			string password,
			Genders gender,
			double salary,
			int bsn,
			string contactNumber,
			string iceName,
			string iceNumber,
			double partTimeFactor
		)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Nationality = nationality;
			Email = email;
			AddressZipCode = addressZipCode;
			AddressCity = addressCity;
			AddressStreet = addressStreet;
			DateOfEmployment = dateOfEmployment;
			PositionId = positionId;
			DepartmentId = departmentId;
			IsActive = isActive;
			Login = login;
			Password = password;
			Gender = gender.ToString();
			Salary = salary;
			Bsn = bsn;
			ContactNumber = contactNumber;
			IceName = iceName;
			IceNumber = iceNumber;
			PartTimeFactor = partTimeFactor;
		}

		/// <summary>
		/// Constructor for pulling a person from the database
		/// </summary>
		/// <param name="id"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="dateOfBirth"></param>
		/// <param name="nationality"></param>
		/// <param name="email"></param>
		/// <param name="addressZipCode"></param>
		/// <param name="addressCity"></param>
		/// <param name="addressStreet"></param>
		/// <param name="dateOfEmployment"></param>
		/// <param name="positionId"></param>
		/// <param name="departmentId"></param>
		/// <param name="isActive"></param>
		/// <param name="login"></param>
		/// <param name="gender"></param>
		/// <param name="salary"></param>
		/// <param name="bsn"></param>
		/// <param name="contactNumber"></param>
		/// <param name="iceName"></param>
		/// <param name="iceNumber"></param>
		/// <param name="partTimeFactor"></param>
		public Person(
			int id,
			string firstName,
			string lastName,
			DateTime dateOfBirth,
			string nationality,
			string email,
			string addressZipCode,
			string addressCity,
			string addressStreet,
			DateTime dateOfEmployment,
			int positionId,
			int departmentId,
			bool isActive,
			string login,
			Genders gender,
			double salary,
			int bsn,
			string contactNumber,
			string iceName,
			string iceNumber,
			double partTimeFactor
		)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Nationality = nationality;
			Email = email;
			AddressZipCode = addressZipCode;
			AddressCity = addressCity;
			AddressStreet = addressStreet;
			DateOfEmployment = dateOfEmployment;
			PositionId = positionId;
			DepartmentId = departmentId;
			IsActive = isActive;
			Login = login;
			Gender = gender.ToString();
			Salary = salary;
			Bsn = bsn;
			ContactNumber = contactNumber;
			IceName = iceName;
			IceNumber = iceNumber;
			PartTimeFactor = partTimeFactor;
		}

		public Person()
		{
		}

		#endregion props

		public string GetName()
		{
			return this.FirstName + " " + this.LastName;
		}

		public override string ToString()
		{
			return $"{this.FirstName} {this.LastName}, {this.Id}";
		}
	}
}