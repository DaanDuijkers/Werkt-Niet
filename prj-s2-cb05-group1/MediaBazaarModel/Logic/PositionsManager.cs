using MediaBazaarModel.sql;
using System.Collections.Generic;

namespace MediaBazaarModel.Logic
{
	public class PositionsManager : NotifiableManager<Position, SqlConPositions>
	{
		public PositionsManager()
		{
			_dbCon = new SqlConPositions();
		}

		/// <summary>
		/// Gets list of Positions per given department
		/// </summary>
		/// <param name="departmentId"></param>
		/// <returns></returns>
		public List<Position> GetPositionsByDepartmentId(int departmentId)
		{
			var deptPositions = new List<Position>();

			foreach (var position in base.ToArray())
			{
				if (position.DepartmentId == departmentId)
				{
					deptPositions.Add(position);
				}
			}

			return deptPositions;
		}
	}
}