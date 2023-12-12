using Lesson7Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        Cone myCone = new Cone(3, 4);
        double myBaseSurfaceArea = myCone.BaseSurfaceArea();
        Console.WriteLine($"Base surfase area is {myBaseSurfaceArea}");
        double myTotalSurfaceArea = myCone.TotalSurfaceArea();
        Console.WriteLine($"Total surface area is {myTotalSurfaceArea}");
    }
}