namespace SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintPositiveOrNegativNumber(input);
        }
        static void PrintPositiveOrNegativNumber(int number)
        {
            if (number < 0)
            { Console.WriteLine($"The number {number} is negative."); }
            else if (number == 0) { Console.WriteLine($"The number {number} is zero."); }
            else { Console.WriteLine($"The number {number} is positive."); }
        }
    }
}
