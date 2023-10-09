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
        static bool IsPalindrome(string symbols)
        {
            int left = 0; int right = symbols.Length - 1;
            while (left < right)
            {
                if (symbols[left] != symbols[right])
                    return false;
            }
            left++;
            right--;

            return true;
        }
    }
}
