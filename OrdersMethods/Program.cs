
namespace OrdersMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Order(orderType, quantity);
        }

        static void Order(string orderType, int quantity)
        {
            if (orderType == "coffee") {; Console.WriteLine($"{1.5 * quantity:F2}"); }
            else if (orderType == "water") { Console.WriteLine($"{1.00 * quantity:F2}"); }
            else if (orderType == "coke") { Console.WriteLine($"{1.40 * quantity:F2}"); }
            else if (orderType == "snacks") { Console.WriteLine($"{2.00 * quantity:F2}"); }
        }
    }
}
