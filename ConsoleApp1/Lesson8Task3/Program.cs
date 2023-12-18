using Lesson8Task3;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray = {1, 3, 5, 8, 2, 16 };
        int maxNumber = myArray.FindMaxValue();
        Console.WriteLine(maxNumber);
    }
}