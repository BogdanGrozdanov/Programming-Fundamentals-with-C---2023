namespace OrdersAssociative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Orders> kvp = new Dictionary<string, Orders>();
            while (true)
            {
                string[] orders = InputStringsArray();
                if (orders[0] == "buy") { break; }
                string item = orders[0];
                double price = double.Parse(orders[1]);
                double quantity = double.Parse(orders[2]);
            }

        }
        public static string[] InputStringsArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
    public class Orders
    {
        public Orders(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }
        public double Price { get; set; }
        public double Quantity { get; set; }
    }
}
