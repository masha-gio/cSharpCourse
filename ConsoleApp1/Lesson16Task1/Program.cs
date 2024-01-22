namespace Lesson16Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { -10, 22, 13, 43, -5, -12, 100 };
            var negativeNumbers = numbers.Where(x=> x < 0 && x%2 == 0).ToList();
            negativeNumbers.Reverse();

            foreach(int number in negativeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
