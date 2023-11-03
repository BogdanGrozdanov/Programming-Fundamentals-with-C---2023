using System.Security.Cryptography.X509Certificates;

namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordSinonym = new Dictionary<string, List<string>>();
            for (int i = 0; i < wordCount; i++)
            {
                string word = Console.ReadLine();
                string sinonym = Console.ReadLine();

                if (!wordSinonym.ContainsKey(word))
                {
                    wordSinonym.Add(word, new List<string>());
                    wordSinonym[word].Add(sinonym);
                }
                else { wordSinonym[word].Add(sinonym); }
            }
            foreach (var item in wordSinonym)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
