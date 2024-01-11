namespace Lesson11Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda panda1 = new Panda(Gender.Female, Colour.WhiteBlack, 80, 15, 8, "Mai");
            Panda panda2 = new Panda(Gender.Male, Colour.Black, 90, 12, 6, "Kai");

            try
            {
                // Mate two pandas
                Panda babyPanda = panda1 + panda2;
                Console.WriteLine($"Baby Panda: {babyPanda}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // Attack one panda to reduce its HP
            Panda attackedPanda = panda2 - panda1;

            Console.WriteLine($"Attacked Panda: {attackedPanda}");
        }
    }
}