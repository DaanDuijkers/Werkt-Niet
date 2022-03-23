using MediaBazaarModel.sql;
using System;
using System.Collections.Generic;

namespace MediaBazaarModel.Logic
{
	public class ShiftManager : NotifiableManager<Shift, SqlConShifts>
	{
		public ShiftManager()
		{
			_dbCon = new SqlConShifts();
		}

		public override bool Update(Shift obj)
		{
			_dbCon.UpdateItem(obj);
			obj.AllWorkersIntoIds();
			obj.ShiftWorkers.Update(null);
			return true;
		}

		public bool UpdateAll()
		{
			foreach (var shift in base.ToArray())
			{
				if (shift.WasModified)
				{
					Update(shift);
				}
			}

			return true;
		}

		/// <summary>
		/// Checks for personal scheduling and returns list of shifts that person is assigned to
		/// </summary>
		/// <param name="person"></param>
		/// <returns></returns>
		public List<Shift> CheckPersonShifts(Person person)
		{
			var personShifts = new List<Shift>();
			foreach (var shift in base.ToArray())
			{
				if (shift.ShiftWorkers.Contains(person))
				{
					personShifts.Add(shift);
				}
			}

			return personShifts;
		}

		public Shift FindShift(DateTime date, ShiftTypes shiftType, int departmentId)
		{
			if (departmentId == -1)
			{
				foreach (var shift in base.ToArray())
				{
					if (shift.Date == date && shift.ShiftType == shiftType)
					{
						return shift;
					}
				}
			}
			else
			{
				foreach (var shift in base.ToArray())
				{
					if (shift.Date == date && shift.ShiftType == shiftType && shift.DepartmentId == departmentId)
					{
						return shift;
					}
				}
			}

			return null;
		}

		public Shift FindShift(Shift shiftToCompare)
		{
			foreach (var shift in base.ToArray())
			{
				if (shift.Date == shiftToCompare.Date && shift.ShiftType == shiftToCompare.ShiftType && shift.DepartmentId == shiftToCompare.DepartmentId)
				{
					return shift;
				}
			}

			return null;
		}

		public void GetPersonsFromIds(PersonManager personManager)
		{
			foreach (var shift in base.ToArray())
			{
				shift.GetPeopleFromIds(personManager);
			}
		}
	}
}