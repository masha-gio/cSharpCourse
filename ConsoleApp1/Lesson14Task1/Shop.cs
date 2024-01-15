namespace Lesson14Task1
{
	internal class Shop
	{
		private string seller;
		private Dictionary<string, Product> products;

		public Shop(string seller, Dictionary<string, Product> products = null)
		{
			if (string.IsNullOrEmpty(seller))
			{
				throw new ArgumentException("Seller is away.");
			}

			this.seller = seller;
			this.products = products ?? new Dictionary<string, Product>();
		}

		public void AddProduct(Product product)
		{
			if (this.products.ContainsKey(product.Name))
			{
				throw new ArgumentException($"Product '{product.Name}' is already in the shop.");
			}
			else
			{
				this.products[product.Name] = product;
			}
		}

		public Product SellProduct(string productName, decimal paymentAmount)
		{
			if (!this.products.ContainsKey(productName))
			{
				throw new ArgumentException($"We could not find product '{productName}' in the shop.");
			}

			Product product = this.products[productName];
			if (paymentAmount < product.Price)
			{
				throw new ArgumentException("Insufficient funds.");
			}

			this.products.Remove(productName);
			return product;
		}

		public void LiquidateShop()
		{
			if (this.products.Count == 0)
			{
				throw new ArgumentException("The shop is empty. Shop needs to be liquidated");
			}
			else
			{
				throw new ArgumentException("The shop can not be liquidated as there are products left.");
			}
		}
	}
}
