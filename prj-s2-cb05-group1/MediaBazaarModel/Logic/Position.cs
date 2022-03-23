namespace MediaBazaarModel.Logic
{
	public class Position : HasId
	{
		public string PositionName { get; set; }
		public string AccessLevel { get; set; }
		public int DepartmentId { get; set; }

		/// <summary>
		/// Constructor for creating new positions
		/// </summary>
		/// <param name="positionName"></param>
		/// <param name="accessLevel"></param>
		/// <param name="departmentId"></param>
		public Position(string positionName, string accessLevel, int departmentId)
		{
			PositionName = positionName;
			AccessLevel = accessLevel;
			DepartmentId = departmentId;
		}

		/// <summary>
		/// Constructor for positions pulled from the database
		/// </summary>
		/// <param name="id"></param>
		/// <param name="positionName"></param>
		/// <param name="accessLevel"></param>
		/// <param name="departmentId"></param>
		public Position(int id, string positionName, string accessLevel, int departmentId)
		{
			Id = id;
			PositionName = positionName;
			AccessLevel = accessLevel;
			DepartmentId = departmentId;
		}

		public Position()
		{
		}

		public override string ToString()
		{
			return PositionName;
		}
	}
}