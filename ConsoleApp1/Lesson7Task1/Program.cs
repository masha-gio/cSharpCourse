using ArrayWorkerLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] currentArray = new[] { 1, 2, 3, 4 };
        Console.WriteLine("Original array:");
        PrintArray(currentArray);
        ArrayWorker array = new ArrayWorker(currentArray);
        int[] invertedArray = array.InvertArray(currentArray);
        Console.WriteLine("Inverted array:");
        PrintArray(invertedArray);
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.WriteLine(i + " ");
        }
    }
}