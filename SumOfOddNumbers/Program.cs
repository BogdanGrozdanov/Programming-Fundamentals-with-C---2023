namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumOdd = 0;

            for (int i = 1; i <= n*2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sumOdd += i;
                }
                
            }
            Console.WriteLine($"Sum: {sumOdd}");
        }
    }
}