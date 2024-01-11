namespace Lesson11Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Water water = new Water(200, 90); 
                GroundCoffee groundCoffee = new GroundCoffee(20, CoffeeStrength.Strong); 

                Coffee coffee = water + groundCoffee;

                Console.WriteLine(coffee);
            }
        }
    }
}