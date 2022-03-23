namespace MediaBazaarModel.Logic
{
	public interface ISqlConnectable<T, out TManager>
	{
		public void AddItem(T item);

		public void RemoveItem(T item);

		public void UpdateItem(T item);

		public TManager GetAllFromDatabase();

		public T GetIdFromDatabase(int id);
	}
}