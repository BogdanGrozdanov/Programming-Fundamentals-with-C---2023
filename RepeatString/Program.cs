
namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringa = Console.ReadLine();
            string repeat = Console.ReadLine();
            string result = RepeatStrings(stringa, repeat);
            Console.WriteLine(result);
        }

        static string RepeatStrings(string stringa, string repeat)
        {
            string result = string.Empty;
            for (int i = 0; i < int.Parse(repeat); i++) { result += stringa; };
            return result;
        }
    }
}
