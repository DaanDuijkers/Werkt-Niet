using MediaBazaarModel.sql;

namespace MediaBazaarModel.Logic
{
	public class OrderRequestManager : NotifiableManager<OrderRequest, SqlConOrders>
	{
		public OrderRequestManager()
		{
			_dbCon = new SqlConOrders();
		}
	}
}