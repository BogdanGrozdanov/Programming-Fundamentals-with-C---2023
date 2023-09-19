using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int countOrders = int.Parse(Console.ReadLine());
            //
            double total = 0;
            for (int i = 0; i < countOrders; i++)
            {
                double pricePerCapsul = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulCount = int.Parse(Console.ReadLine());
                double result = ((days * capsulCount) * pricePerCapsul);
                Console.WriteLine($"The price for the coffee is: ${result:F2}");
                total += result;
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}