using System.Numerics;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalYield = 0;

            while (startingYield > 99)
            {
                days++;
                totalYield += startingYield;
                totalYield -= 26;
                startingYield -= 10;
            }
            totalYield -= 26;
            if (totalYield < 0) { totalYield = 0; }
            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
