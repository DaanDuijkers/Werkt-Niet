namespace MediaBazaarModel.Logic
{
	public class OrderRequest : HasId
	{
		public int OrderId { get; set; }
		public int UserId { get; set; }
		public bool IsExternalOrder { get; set; }
		public int OrderStatus { get; set; }
	}
}