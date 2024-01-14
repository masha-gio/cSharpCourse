namespace Lesson13Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<SampleClass> customList = new CustomList<SampleClass>();

            customList.AddAndSort(new SampleClass(3));
            customList.AddAndSort(new SampleClass(1));
            customList.AddAndSort(new SampleClass(2));

            customList.AddAndSort(new SampleClass(4));
        }
    }
}