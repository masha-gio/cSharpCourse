internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please enter your symbol:");
            var character = Convert.ToString(Console.ReadLine());
            if (character != null)
            {
                switch (character.ToUpperInvariant())
                {
                    case "W":
                        Console.WriteLine("Move up");
                        break;
                    case "S":
                        Console.WriteLine("Move down");
                        break;
                    case "A":
                        Console.WriteLine("Move right");
                        break;
                    case "D":
                        Console.WriteLine("Move left");
                        break;
                    default:
                        Console.WriteLine("Stay. If you want to move enter W, S, A, D");
                        break;
                }
            }
            else
            {
                Console.WriteLine("A symbol is expected.");
            }
        }
    }
}