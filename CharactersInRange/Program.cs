
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
            for (int i = startChar+1; i < endChar; i++)
            {
                char character = (char)i;
                Console.Write(character +" ");
            }
        }
    }
}
