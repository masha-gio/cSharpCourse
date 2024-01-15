namespace Lesson14Task1
{
	internal class Program
	{
		private static void Main()
		{
			string seller = "John Doe";

			Product product1 = new Product { Name = "TV", Price = 1000 };
			Product product2 = new Product { Name = "Fridge", Price = 1500 };

			Shop shop = new Shop(seller);

			// Adding products to the shop
			shop.AddProduct(product1);
			shop.AddProduct(product2);

			// Selling a product
			try
			{
				Product soldProduct = shop.SellProduct("TV", 1200);
				Console.WriteLine($"Sold product: {soldProduct.Name}");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine($"Sale error: {ex.Message}");
			}

			// Liquidating the shop
			try
			{
				shop.LiquidateShop();
				Console.WriteLine("The shop is liquidated.");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine($"Shop liquidation error: {ex.Message}");
			}
		}
	}

}