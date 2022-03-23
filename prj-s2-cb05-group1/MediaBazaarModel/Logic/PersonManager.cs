using MediaBazaarModel.sql;
using System.Collections.Generic;

namespace MediaBazaarModel.Logic
{
	public class PersonManager : NotifiableManager<Person, SqlConPerson>
	{
		public PersonManager()
		{
			_dbCon = new SqlConPerson();
		}

		/// <summary>
		/// Returns list of Persons from given department
		/// </summary>
		/// <param name="departmentId"></param>
		/// <returns></returns>
		public List<Person> FindAllPersonsFromDepartment(int departmentId)
		{
			//return ListPerson.Where(person => person.DepartmentId == departmentId).ToList();
			var persons = new List<Person>();

			foreach (var person in base.ToArray())
			{
				if (person.DepartmentId == departmentId)
				{
					persons.Add(person);
				}
			}

			return persons;
		}

		/// <summary>
		/// Returns list of Persons from given department
		/// </summary>
		/// <param name="departmentId"></param>
		/// <returns></returns>
		public List<Person> FindAllActivePersonsFromDepartment(int departmentId)
		{
			//return ListPerson.Where(person => person.DepartmentId == departmentId).ToList();
			var persons = new List<Person>();

			if (departmentId == -1)
			{
				foreach (var person in base.ToArray())
				{
					if (person.IsActive)
					{
						persons.Add(person);
					}
				}
			}
			else
			{
				foreach (var person in base.ToArray())
				{
					if (person.DepartmentId == departmentId && person.IsActive)
					{
						persons.Add(person);
					}
				}
			}

			return persons;
		}

		public override bool Add(Person obj)
		{
			_dbCon.AddItem(obj);
			base.Add(obj);
			return true;
		}
	}
}