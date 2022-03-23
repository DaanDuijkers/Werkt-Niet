using System;
using System.Diagnostics.CodeAnalysis;

namespace MediaBazaarModel.Logic
{
	public class OrderRequestPosition : HasId
	{
		public int ProductId { get; set; }
		public int OrderRequestId { get; set; }
		public int Quantity { get; set; }
		public int OrderPositionStatusId { get; set; }
		public string OrderPositionStatus { get; set; }
		public DateTime ClosedTimestamp { get; set; }
		public int ClosedById { get; set; }

		public OrderRequestPosition(int id, int productId, int orderRequestId, int quantity, int orderPositionStatusId,
			[NotNull] string orderPositionStatus, DateTime closedTimestamp, int closedById)
		{
			Id = id;
			ProductId = productId;
			OrderRequestId = orderRequestId;
			Quantity = quantity;
			OrderPositionStatusId = orderPositionStatusId;
			OrderPositionStatus = orderPositionStatus ?? throw new ArgumentNullException(nameof(orderPositionStatus));
			ClosedTimestamp = closedTimestamp;
			ClosedById = closedById;
		}

		public OrderRequestPosition(int id, int productId, int orderRequestId, int quantity, int orderPositionStatusId, string orderPositionStatus)
		{
			Id = id;
			ProductId = productId;
			OrderRequestId = orderRequestId;
			Quantity = quantity;
			OrderPositionStatusId = orderPositionStatusId;
			OrderPositionStatus = orderPositionStatus;
		}

		public OrderRequestPosition(int productId, int orderRequestId, int quantity, int orderPositionStatusId, [NotNull] string orderPositionStatus)
		{
			ProductId = productId;
			OrderRequestId = orderRequestId;
			Quantity = quantity;
			OrderPositionStatusId = orderPositionStatusId;
			OrderPositionStatus = orderPositionStatus;
		}
	}
}