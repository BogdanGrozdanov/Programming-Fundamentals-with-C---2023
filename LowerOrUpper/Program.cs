namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            if (letter == letter.ToUpper()) { Console.WriteLine("upper-case"); }
            else { Console.WriteLine("lower-case"); }
        }
    }
}
