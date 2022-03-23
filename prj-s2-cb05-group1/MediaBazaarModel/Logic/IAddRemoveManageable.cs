namespace MediaBazaarModel.Logic
{
	public interface IAddRemoveManageable<T>
	{
		public bool Add(T obj);

		public bool Remove(T obj);

		public bool Update(T obj);

		public void GetAllFromDatabase();

		//public T GetIdInfoFromDatabase(int Id);

		T FindById(int id);
	}
}