using Lesson9Task1and2;

internal class Program
{
    private static void Main(string[] args)
    {
        Herbivore rabbit = new Herbivore("Rabbit", 3, true);
        rabbit.Live();
        Herbivore dear = new Herbivore("Dear", 3, true);
        dear.Live();

        Console.WriteLine();
        Animal snake = new Animal("Snake", 3);
        snake.Live();

        Console.WriteLine();
        Predator wolf = new Predator("Wolf", 5, true);
        wolf.Live();
        Predator bear = new Predator("Bear", 5, true);
        bear.Live();

        Zoo zoo = new Zoo();

        zoo.AcceptAnimal(wolf);
        zoo.AcceptAnimal(bear);
        zoo.AcceptAnimal(rabbit);
        zoo.AcceptAnimal(dear);
        zoo.AcceptAnimal(snake);

        zoo.DisplayEnclosures();
    }
}