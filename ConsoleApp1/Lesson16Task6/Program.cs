using System;

namespace Lesson16Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>() {
                new Cars { Id = 1, Name = "Toyota", Age = 2005 },
                new Cars { Id = 2, Name = "Honda", Age = 2015 },
                new Cars { Id = 3, Name = "Ford", Age = 2012 }
        };

            //один покупатель, одна машина
            //List<Buyers> buyers = new List<Buyers>() {
            //new Buyers { Id = 2, Name = "Bob", CarId = 2 },
            //new Buyers { Id = 1, Name = "Alice", CarId = 1 },            
            //new Buyers { Id = 3, Name = "Charlie", CarId = 3 }
            //};

            List<Buyers> buyers = new List<Buyers>() {
                new Buyers { Id = 2, Name = "Bob", CarId = new List<int> { 2 } },
                new Buyers { Id = 1, Name = "Alice", CarId = new List<int> { 1, 2 } },
                new Buyers { Id = 3, Name = "Charlie", CarId = new List<int> { 3 } }
            };

            //один покупатель, одна машина
            //var BoughtCars = buyers.Join(cars, b => b.CarId, c => c.Id, (b, c) => new { BuyerName = b.Name, CarName = c.Name, CarAge = c.Age }).OrderBy(name => name.BuyerName);

            var BoughtCars = buyers.SelectMany(buyer => buyer.CarId, (buyer, carId) => new { BuyerName = buyer.Name, CarId = carId })
                .Join(cars, b => b.CarId, c => c.Id, (b, c) => new { BuyerName = b.BuyerName, CarName = c.Name, CarAge = c.Age })
                .OrderBy(name => name.BuyerName);

            foreach (var car in BoughtCars)
            {
                Console.WriteLine($"{car.BuyerName} has bought {car.CarName}, year of manufacture: {car.CarAge}");
            }
        }
    }
}
