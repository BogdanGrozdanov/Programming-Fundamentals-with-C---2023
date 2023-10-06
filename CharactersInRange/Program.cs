
namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            PrintCharInRange(startChar, endChar);
        }

        private static void PrintCharInRange(char startChar, char endChar)
        {
            char start = default(char);
            char end = default(char);
            if (startChar > endChar)
            {
                start = endChar;
                end = startChar;
            }
            else { start = startChar; end = endChar; }
            for (int i = start + 1; i < end; i++)
            {
                char character = (char)i;
                Console.Write(character + " ");
            }
        }
    }
}
