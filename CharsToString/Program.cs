namespace CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string striga = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char character = char.Parse(Console.ReadLine());
                striga += character;
            }
            Console.WriteLine(striga);
        }
    }
}
