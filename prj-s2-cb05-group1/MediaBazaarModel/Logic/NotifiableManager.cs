using System.Collections.Generic;
using System.Collections.Specialized;

namespace MediaBazaarModel.Logic
{
	/// <summary>
	/// Base class for managers
	/// </summary>
	/// <typeparam name="T">is the type</typeparam>
	/// <typeparam name="TCon">TCon is the connection class for it</typeparam>
	public abstract class NotifiableManager<T, TCon> : List<T>, IAddRemoveManageable<T>,
		INotifyCollectionChanged where T : HasId where TCon : ISqlConnectable<T, NotifiableManager<T, TCon>>
	{
		protected TCon _dbCon;

		public new virtual bool Add(T obj)
		{
			if (base.Contains(obj))
			{
				return false;
			}

			base.Add(obj);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, obj));
			return true;
		}

		public new virtual bool Remove(T obj)
		{
			if (base.Contains(obj))
			{
				base.Remove(obj);
				CollectionChanged?.Invoke(this,
					new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, obj));
				return true;
			}

			return false;
		}

		public virtual bool Update(T obj)
		{
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			return true;
		}

		public virtual void GetAllFromDatabase()
		{
			base.Clear();
			base.AddRange(_dbCon.GetAllFromDatabase());
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}

		//public T GetIdInfoFromDatabase(int Id)
		//{
		//	throw new NotImplementedException();
		//}

		public virtual T FindById(int id)
		{
			foreach (var findById in base.ToArray())
			{
				if (findById.Id == id)
				{
					return findById;
				}
			}

			return null;
		}

		/// <summary>
		/// Adds people the shift, to be used only from database retrieval. Is used to show shifts which are already in the database, does not trigger add event. For retrieval from other PersonManager class
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public bool AddFromId(T obj)
		{
			if (base.Contains(obj))
			{
				return false;
			}
			base.Add(obj);
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			return true;
		}

		public event NotifyCollectionChangedEventHandler? CollectionChanged;
	}
}