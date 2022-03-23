using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace MediaBazaarModel.Logic
{
	public class Shift : HasId
	{
		private PersonManager _shiftWorkers;
		public DateTime Date { get; set; }
		public ShiftTypes ShiftType { get; set; }
		public int DepartmentId { get; set; }
		public bool WasModified { get; private set; }

		public PersonManager ShiftWorkers
		{
			get => _shiftWorkers;
			set
			{
				_shiftWorkers = value;
				ShiftWorkers.CollectionChanged += ShiftWorkers_CollectionChanged;
			}
		}

		public List<int> WorkersIdList { get; private set; }

		/// <summary>
		/// This constructor is for shifts pulled from database
		/// </summary>
		/// <param name="id"></param>
		/// <param name="date"></param>
		/// <param name="shiftType"></param>
		/// <param name="departmentId"></param>
		/// <param name="shiftWorkers"></param>
		public Shift(int id, DateTime date, ShiftTypes shiftType, int departmentId, List<int> shiftWorkers)
		{
			Id = id;
			Date = date;
			ShiftType = shiftType;
			DepartmentId = departmentId;
			WorkersIdList = shiftWorkers;
			WasModified = false;
			ShiftWorkers.CollectionChanged += ShiftWorkers_CollectionChanged;
		}

		private void ShiftWorkers_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove)
			{
				WasModified = true;
				//MessageBox.Show(e.Action.ToString() + ' ' + sender.ToString());
			}
			else if (e.Action == NotifyCollectionChangedAction.Reset)
			{
				WasModified = false;
				//MessageBox.Show(e.Action.ToString() + ' ' + sender.ToString());
			}
		}

		public Shift(int id, DateTime date, ShiftTypes shiftType, int departmentId)
		{
			Id = id;
			Date = date;
			ShiftType = shiftType;
			DepartmentId = departmentId;
			WasModified = false;
			WorkersIdList = new List<int>();
			ShiftWorkers = new PersonManager();
			ShiftWorkers.CollectionChanged += ShiftWorkers_CollectionChanged;
		}

		/// <summary>
		/// This constructor is for creating new workshifts
		/// </summary>
		/// <param name="date"></param>
		/// <param name="shiftType"></param>
		/// <param name="departmentId"></param>
		public Shift(DateTime date, ShiftTypes shiftType, int departmentId)
		{
			Id = -1;
			Date = date;
			ShiftType = shiftType;
			DepartmentId = departmentId;
			WasModified = false;
			WorkersIdList = new List<int>();
			ShiftWorkers = new PersonManager();
			ShiftWorkers.CollectionChanged += ShiftWorkers_CollectionChanged;
		}

		public void GetPeopleFromIds(PersonManager personManager)
		{
			foreach (var i in WorkersIdList)
			{
				var person = personManager.FindById(i);
				if (person != null)
				{
					ShiftWorkers.AddFromId(person);
				}
			}
			WorkersIdList.Clear();
		}

		public void AddId(int id)
		{
			WorkersIdList.Add(id);
		}

		public void AllWorkersIntoIds()
		{
			WorkersIdList.Clear();
			foreach (var shiftWorker in ShiftWorkers)
			{
				WorkersIdList.Add(shiftWorker.Id);
			}
		}
	}
}