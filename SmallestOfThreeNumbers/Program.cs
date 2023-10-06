
namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirthInt = int.Parse(Console.ReadLine());
            GetSmallestInteger(firstInt, secondInt, thirthInt);
        }
         static void GetSmallestInteger(int firstInt, int secondInt, int thirthInt)
        {
             int[] numbers = new int[] { firstInt, secondInt, thirthInt };
            int min=numbers.Min();
            Console.WriteLine(min);
        }
    }
}
