internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int n = 0;
        CoundDown(n);


    }
    static void CoundDown(int n)
    {
        
        Console.WriteLine(n);
            if (n < 200)
        {
            CoundDown(n * (n + 1));
        }
           // else { return true; }
    }
}