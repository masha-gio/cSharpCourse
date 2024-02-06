using Lesson19Task3;

namespace Lesson19Task3
{
    internal class Program
    {
        static async Task Main()
        {
            // Создаем пиццерию с 3 работниками
            PizzaPlace pizzaPlace = new PizzaPlace(3);

            // Создаем список задач на приготовление различных видов пицц
            List<Task> pizzaTasks = new List<Task>
        {
            pizzaPlace.CookPizzaAsync("Margherita"),
            pizzaPlace.CookPizzaAsync("Pepperoni"),
            pizzaPlace.CookPizzaAsync("Vegetarian"),
            pizzaPlace.CookPizzaAsync("Hawaiian"),
            pizzaPlace.CookPizzaAsync("Meat Lovers")
        };

            // Ожидаем завершения всех задач
            await Task.WhenAll(pizzaTasks);

            Console.WriteLine("All pizzas are ready!");
        }
    }
}