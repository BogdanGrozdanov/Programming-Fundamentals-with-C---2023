namespace ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string revers = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char character = char.Parse(Console.ReadLine());
                revers += character;
            }

            for (int i = revers.Length - 1; i >= 0; i--)
            {
                Console.Write(revers[i]+" ");
            }
        }
    }
}
