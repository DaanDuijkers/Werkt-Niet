using Dapper;
using MediaBazaarModel.Logic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

//using System.Windows.Forms;

namespace MediaBazaarModel.sql
{
	public class SqlConPerson : ISqlConnectable<Person, PersonManager>
	{
		public void AddItem(Person item)
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				connection.Execute("AddUser @FirstName, @LastName, @DateOfBirth, @Nationality, @Email, @AddressZipCode," +
								   "@AddressCity, @AddressStreet, @DateOfEmployment, @PositionId, @DepartmentId, @Login," +
								   "@Password, @Gender, @Salary, @Bsn, @ContactNumber, @IceName, @IceNumber, @PartTimeFactor;", item);
			}
		}

		/// <summary>
		/// This one is a bit tricky you have to pass the StopDate as the DateOfEmployment
		/// </summary>
		/// <param name="item"></param>
		public void RemoveItem(Person item)
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				connection.Execute("RemoveUser @Id, @StopDate;", new { Id = item.Id, StopDate = item.DateOfEmployment });
			}
		}

		public void UpdateItem(Person item)
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				connection.Execute("UpdateUser @Id, @FirstName, @LastName, @DateOfBirth, @Nationality," +
								   "@Email, @AddressZipCode, @AddressCity, @AddressStreet, @Login, @Password," +
								   "@Gender, @Bsn, @ContactNumber, @IceName, @IceNumber;", item);
			}
		}

		public PersonManager GetAllFromDatabase()
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var personList = connection.Query<Person>($"GetAllUsers").ToList();
				var personManager = new PersonManager();
				personManager.AddRange(personList);

				return personManager;
			}
		}

		public Person GetIdFromDatabase(int personId)
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var person = connection.QueryFirstOrDefault<Person>($"GetUserById @Id", new { Id = personId });

				return person;
			}
		}

		public int Login(string username, string password)
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var login = connection.QueryFirstOrDefault<LoginDb>($"GetLogin @Login", new { Login = username });

				if (BCrypt.Net.BCrypt.Verify(password, login.UserPassword))
				{
					return login.Id;
				}
				return -1;
			}
		}
	}
}