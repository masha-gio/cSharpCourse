namespace Lesson12Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPerson = new List<Person>
        {
            new Person("Alice", 25, "Female"),
            new Person("Bob", 30, "Male"),
            new Person("Charlie", 22, "Male"),
            new Person("Diana", 28, "Female"),
            new Person("Eve", 35, "Female"),
            new Person("Frank", 32, "Male"),
            new Person("Grace", 27, "Female"),
            new Person("Henry", 29, "Male"),
            new Person("Ivy", 26, "Female"),
            new Person("Jack", 31, "Male")
        };

            Console.WriteLine("Before Sorting:");
            foreach (var person in listOfPerson)
            {
                Console.WriteLine(person);
            }

            listOfPerson.Sort();

            Console.WriteLine("\nAfter Sorting using IComparable:");
            foreach (var person in listOfPerson)
            {
                Console.WriteLine(person);
            }

            List<Person> listOfPersonCopy = new List<Person>(listOfPerson);

            listOfPersonCopy.Sort(new PersonComparer());

            Console.WriteLine("\nAfter Sorting using PersonComparer:");
            foreach (var person in listOfPersonCopy)
            {
                Console.WriteLine(person);
            }
        }
    }
}