namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());


            long firstCondition = num1 + num2;
            long secondCondition = firstCondition / num3;
            long thirdCondition = secondCondition * num4;
            Console.WriteLine(thirdCondition);
        }
    }
}
