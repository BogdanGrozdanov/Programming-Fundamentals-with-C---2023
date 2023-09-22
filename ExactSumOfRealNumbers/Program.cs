using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            decimal totalSum = 0;

            while (n != counter) { counter++; decimal number = decimal.Parse(Console.ReadLine()); totalSum += number; }
            Console.WriteLine(totalSum);
        }
    }
}
