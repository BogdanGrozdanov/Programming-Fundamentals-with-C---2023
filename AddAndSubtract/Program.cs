namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer1 = int.Parse(Console.ReadLine());
            int integer2 = int.Parse(Console.ReadLine());
            int integer3 = int.Parse(Console.ReadLine());
            int addInteger = AddTwoIntegers(integer1, integer2);
            int result = SubstractTwoInteger(addInteger, integer3);
            Console.WriteLine(result);
        }
        static int AddTwoIntegers(int first, int second)
        {
            int result = first + second;
            return result;
        }
        static int SubstractTwoInteger(int first, int second)
        {
            int result = first - second;
            return result;
        }
    }
}
