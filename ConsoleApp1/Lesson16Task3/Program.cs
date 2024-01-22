namespace Lesson16Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 11, -20, -5, 4, 5, 8, -1, 9, 2, 0, -11, 15, 3, -3, 4, 0, 20 };

            var positiveNumbers = numbers.Where(x => x >= 0).ToList();
            var negativeOddNumbers = numbers.Where(x => x % 2 != 0).Distinct().ToList();
            var negativeEvenNumbers = numbers.Where(x => x < 0 && x % 2 == 0).Reverse().ToList();
            var tens = numbers.Where(x => x >= 0 && x > 9 && x < 100).OrderBy(x => x).ToList();

            Console.WriteLine("a) Positive numbers: " + string.Join(", ", positiveNumbers));
            Console.WriteLine("b) Unique odd numbers: " + string.Join(", ", negativeOddNumbers));
            Console.WriteLine("c) Even negative numbers in reverse order: " + string.Join(", ", negativeEvenNumbers));
            Console.WriteLine("d) Positive two digit numbers in accending order: " + string.Join(", ", tens));

        }
    }
}
