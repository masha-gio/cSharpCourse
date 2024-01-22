namespace Lesson16Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 5, 7, 9 };

            int median = numbers.Median();

            Console.WriteLine($"Mediana: {median}");
        }
    }
}
