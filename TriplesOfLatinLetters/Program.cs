namespace TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstLetter = 97;
                int lastLeter =firstLetter + n;
            for (int i = firstLetter; i < lastLeter; i++)
            {
                char firstChar = (char)i;

                for (int j = firstLetter; j < lastLeter; j++) 
                {
                    char secondChar = (char)j;

                    for (int k = firstLetter; k < lastLeter; k++)
                    {
                        char thirthChar = (char)k;
                        Console.WriteLine($"{firstChar}{secondChar}{thirthChar}");
                    }
                }
            }
        }
    }
}
