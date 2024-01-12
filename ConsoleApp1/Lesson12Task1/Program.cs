namespace Lesson12Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Teodor", 4, "meow", "black", "meat", "stray");
            Zoo zoo = new Zoo();
            Elephant elephant1 = new Elephant("Dumbo", 4, "whoo", "grey", 100, "grass", "wild");
            Elephant elephant2 = new Elephant("Tumbo", 4, "whoo", "grey", 90, "grass", "wild");

            cat.displayAnimal();

            zoo.AddToCarnivoreEnclosure(cat);
            zoo.AddToHerbivoreEnclosure(elephant2);

            bool areElephantsEqual = elephant1.Equals(elephant2);
            Console.WriteLine($"Are elephants equal? {areElephantsEqual}");
        }
    }
}