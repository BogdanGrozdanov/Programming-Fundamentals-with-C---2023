using System.Threading.Channels;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                bool IsNumberPalindrome = IsPalindrome(input);
                Console.WriteLine(IsNumberPalindrome);

            }

        }
        public static bool IsPalindrome(string symbols)
        {
            return symbols.SequenceEqual(symbols.Reverse());
        }
    }
}
