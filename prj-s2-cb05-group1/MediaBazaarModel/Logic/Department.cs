namespace MediaBazaarModel.Logic
{
	public class Department : HasId
	{
		public string Name { get; set; }
		public int Head { get; set; }
		public int SuggestedAmountOfWorkers { get; set; }
		public bool IsActive { get; set; }

		/// <summary>
		/// Contructor for creating new department
		/// </summary>
		/// <param name="name"></param>
		public Department(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Constructor for pulling departments from db
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		public Department(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public Department()
		{
		}
	}
}