namespace Lesson13Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string> {
            { 1, "apple" },
            { 2, "banana" },
            { 3, "orange" },
            { 4, "grape" },
            { 5, "melon" },
            { 6, "cherry" },
            { 7, "kiwi" },
            { 8, "pear" },
            { 9, "plum" },
            { 10, "peach" } 
            }; 
            Words words = new Words(myDictionary);

            string[] randomWords = words.GenerateRandomWords(3);
            
            for(int i = 0; i < randomWords.Length; i++)
            {
                Console.WriteLine(randomWords[i]);
            }

            foreach(string word in words.FilterWordsByLength(randomWords, 5)) { 
            Console.WriteLine(word);
            }            
        }
    }
}