namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,strings));
        }
    }
}
