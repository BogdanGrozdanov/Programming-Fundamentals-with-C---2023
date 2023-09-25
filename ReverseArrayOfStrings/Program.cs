namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(string.Join(" ", Console.ReadLine()).Split().Reverse());
            string[] strings = Console.ReadLine().Split(" ");
            for (int i = strings.Length - 1; i >= 0; i--)
            { Console.Write(strings[i] + " "); }
        }
    }
}
