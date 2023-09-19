namespace MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number2 <= 10)
            {
                for (int i = number2; i <= 10; i++)
                {
                    Console.WriteLine($"{number1} X {i} = {number1 * i}");
                }
            }
            else { Console.WriteLine($"{number1} X {number2} = {number1 * number2}"); }
        }
    }
}