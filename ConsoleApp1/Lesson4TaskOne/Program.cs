internal class Program
{
    private static void Main(string[] args)
    {
        {
            int num = 200;
            var list = new List<int>();
            while (num <= 500)
            {
                num++;
                if (num % 17 == 0)
                {
                    list.Add(num);
                }
            }
            Console.WriteLine(String.Join(", ", list));
        }
    }
}