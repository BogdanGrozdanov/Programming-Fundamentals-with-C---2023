
namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (type == "string") { Console.WriteLine(GetMax(a, b)); }
            else if (type == "int") { Console.WriteLine(GetMax(int.Parse(a), int.Parse(b))); }
            else if (type == "char") { Console.WriteLine(GetMax(char.Parse(a), char.Parse(b))); }
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0) { return a; } else { return b; }
        }
        static int GetMax(int a, int b)
        {
            if (a.CompareTo(b) > 0) { return a; } else { return b; }
        }
        static char GetMax(char a, char b)
        {
            if (a.CompareTo(b) > 0) { return a; } else { return b; }
        }
    }
}
