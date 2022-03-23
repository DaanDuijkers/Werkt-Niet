using MediaBazaarModel.sql;

namespace MediaBazaarModel.Logic
{
	public class DepartmentManager : NotifiableManager<Department, SqlConDepartments>
	{
		public DepartmentManager()
		{
			_dbCon = new SqlConDepartments();
		}
	}
}