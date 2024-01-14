using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13Task1
{
    internal class Words
    {
        private Dictionary<int, string> dictionary;

        public Words(Dictionary<int, string> customDictionary)
        {
            dictionary = customDictionary;
        }

        public string[] GenerateRandomWords(int count)
        {
            Random random = new Random();
            List<string> words = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int randomKey = random.Next(1, 11);
                words.Add(dictionary[randomKey]);
            }
            return words.ToArray();
        }

        public IEnumerable<string> FilterWordsByLength(string[] words, int minLength)
        {
            foreach (string word in words)
            {
                if (word.Length < minLength)
                {
                    yield return word;
                }
            }
        }
    }
}
