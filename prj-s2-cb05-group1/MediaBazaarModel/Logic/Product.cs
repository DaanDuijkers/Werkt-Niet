using System;

namespace MediaBazaarModel.Logic
{
	public class Product : HasId
	{
		public int ManufacturerId { get; set; }
		public string Manufacturer { get; set; }
		public int SupplierId { get; set; }
		public string Supplier { get; set; }
		public string Name { get; set; }
		public double BuyPrice { get; set; }
		public double SellPrice { get; set; }
		public string Description { get; set; }
		public int CategoryId { get; set; }
		public string Category { get; set; }
		public int ProductStatusId { get; set; }
		public string ProductStatus { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
		public double Depth { get; set; }
		public double Weight { get; set; }

		public Product(int id, int manufacturerId, string manufacturer, int supplierId, string supplier, string name, double buyPrice, double sellPrice, string description, int categoryId, string category, int productStatusId, string productStatus, double width, double height, double depth, double weight)
		{
			Id = id;
			ManufacturerId = manufacturerId;
			Manufacturer = manufacturer;
			SupplierId = supplierId;
			Supplier = supplier;
			Name = name;
			BuyPrice = buyPrice;
			SellPrice = sellPrice;
			Description = description;
			CategoryId = categoryId;
			Category = category;
			ProductStatusId = productStatusId;
			ProductStatus = productStatus;
			Width = width;
			Height = height;
			Depth = depth;
			Weight = weight;
		}

		public Product(int manufacturerId, string manufacturer, int supplierId, string supplier, string name,
			double buyPrice, double sellPrice, string description, int categoryId, string category, int productStatusId,
			string productStatus, double width, double height, double depth, double weight)
		{
			ManufacturerId = manufacturerId;
			Manufacturer = manufacturer ?? throw new ArgumentNullException(nameof(manufacturer));
			SupplierId = supplierId;
			Supplier = supplier ?? throw new ArgumentNullException(nameof(supplier));
			Name = name ?? throw new ArgumentNullException(nameof(name));
			BuyPrice = buyPrice;
			SellPrice = sellPrice;
			Description = description ?? throw new ArgumentNullException(nameof(description));
			CategoryId = categoryId;
			Category = category ?? throw new ArgumentNullException(nameof(category));
			ProductStatusId = productStatusId;
			ProductStatus = productStatus ?? throw new ArgumentNullException(nameof(productStatus));
			Width = width;
			Height = height;
			Depth = depth;
			Weight = weight;
		}
	}
}