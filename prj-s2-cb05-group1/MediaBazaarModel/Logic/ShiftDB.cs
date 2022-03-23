using System;
using System.Collections.Generic;

namespace MediaBazaarModel.Logic
{
	public class ShiftDB
	{
		public int Id { get; set; }
		public DateTime WorkDate { get; set; }
		public string ShiftType { get; set; }
		public int DeptId { get; set; }
		public int UserId { get; set; }
		public ShiftTypes Type => (ShiftTypes)Enum.Parse(typeof(ShiftTypes), ShiftType);

		public Shift ConvertToShift()
		{
			var shift = new Shift(Id, WorkDate, (ShiftTypes)Enum.Parse(typeof(ShiftTypes), ShiftType), DeptId,
				new List<int>()
					{UserId});
			return shift;
		}
	}
}