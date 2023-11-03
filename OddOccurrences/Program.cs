namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split()
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 == 1)
                .SelectMany(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
