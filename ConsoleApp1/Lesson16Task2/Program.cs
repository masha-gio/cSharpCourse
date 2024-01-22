namespace Lesson16Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Hello", "here", "we", "are" };
            var newWord = new string(words.Reverse().Select(s => s[0]).ToArray());

            Console.WriteLine(newWord);
        }
    }
}
