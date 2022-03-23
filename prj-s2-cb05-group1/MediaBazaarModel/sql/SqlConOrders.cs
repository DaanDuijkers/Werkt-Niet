using MediaBazaarModel.Logic;
using System;

namespace MediaBazaarModel.sql
{
	public class SqlConOrders : ISqlConnectable<OrderRequest, OrderRequestManager>
	{
		public void AddItem(OrderRequest item)
		{
			throw new NotImplementedException();
		}

		public void RemoveItem(OrderRequest item)
		{
			throw new NotImplementedException();
		}

		public void UpdateItem(OrderRequest item)
		{
			throw new NotImplementedException();
		}

		public OrderRequestManager GetAllFromDatabase()
		{
			throw new NotImplementedException();
		}

		public OrderRequest GetIdFromDatabase(int id)
		{
			throw new NotImplementedException();
		}
	}
}