namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            Console.WriteLine(String.Join(' ', strings.Reverse().ToArray()));
        }
    }
}
