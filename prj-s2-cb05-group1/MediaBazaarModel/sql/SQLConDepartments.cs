using Dapper;
using MediaBazaarModel.Logic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

//using System.Windows.Forms;

namespace MediaBazaarModel.sql
{
	public class SqlConDepartments : ISqlConnectable<Department, DepartmentManager>
	{
		public void AddItem(Department item)
		{
			throw new NotImplementedException();
		}

		public void RemoveItem(Department item)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(Department item)
		{
			throw new NotImplementedException();
		}

		public DepartmentManager GetAllFromDatabase()
		{
			using (IDbConnection connection = new SqlConnection(Helper.ConVal("MediaBazaarDB")))
			{
				var departmentList = connection.Query<Department>($"GetAllDepartments").ToList();
				var departmentManager = new DepartmentManager();
				departmentManager.AddRange(departmentList);

				return departmentManager;
			}
		}

		public Department GetIdFromDatabase(int id)
		{
			throw new NotImplementedException();
		}
	}
}