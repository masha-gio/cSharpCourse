namespace Lesson14Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ExampleClass example = new ExampleClass();

                try
                {
                    // Попытка обработать пустую строку
                    example.ProcessString("");
                }
                catch (EmptyStringException ex)
                {
                    Console.WriteLine($"Caught unique exception: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught general exception: {ex.Message}");
                }

                try
                {
                    // Попытка обработать непустую строку
                    example.ProcessString("Example");
                }
                catch (EmptyStringException ex)
                {
                    Console.WriteLine($"Caught unique exception: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Caught general exception: {ex.Message}");
                }
            }
        }
    }
}