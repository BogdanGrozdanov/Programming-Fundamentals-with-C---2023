namespace AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] autors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessage = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            while (numberOfMessage > 0)
            {
                int indexOfPhrases = rnd.Next(0, phrases.Length);
                string phrase = phrases[indexOfPhrases];

                int indexOfEvent = rnd.Next(0, events.Length);
                string evente = events[indexOfEvent];

                int indexOfautors = rnd.Next(0, autors.Length);
                string author = autors[indexOfautors];

                int indexOfCities = rnd.Next(0, cities.Length);
                string city = cities[indexOfCities];
                Console.WriteLine($"{phrase} {evente} {author} – {city}.");

                numberOfMessage--;
            }
        }
    }
}
