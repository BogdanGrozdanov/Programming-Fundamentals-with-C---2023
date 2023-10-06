
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
                
            

        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0) { return a; }else { return b; }
        }
        static int GetMax(int a, int b)
        {
            if (a.CompareTo(b) > 0) { return a; } else { return b; }
        }
    }
}
