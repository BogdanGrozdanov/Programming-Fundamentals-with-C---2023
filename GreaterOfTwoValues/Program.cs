

namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var result = string.Empty;
            if (type == "int")
            { int a = int.Parse(Console.ReadLine()); int b = int.Parse(Console.ReadLine()); result = GetMax(a, b).ToString(); }
            else if (type == "char")
            { char a = char.Parse(Console.ReadLine()); char b = char.Parse(Console.ReadLine()); result = GetMax(a, b).ToString(); }
            else if (type == "string")
            { string a = Console.ReadLine(); string b = Console.ReadLine(); result = GetMax(a, b).ToString(); }
            Console.WriteLine(result);
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        static char GetMax(char a, char b)
        {
            return a > b ? a : b;
        }
        static string GetMax(string a, string b)
        {
            string result = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (a.Length == b.Length)
                {
                    if (a[i] >= b[i])
                    { result = a; }
                    else { result = b; }
                }
                else if (a.Length < b.Length)
                { result = b; }
                else
                { result = a; }

            }
            return result;
        }
    }
}
