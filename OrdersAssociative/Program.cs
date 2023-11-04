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

                Orders order = new Orders(price, quantity);

                if (!kvp.ContainsKey(item))
                {
                    kvp.Add(item, order);
                }
                else
                {
                    kvp[item].Price = price;
                    kvp[item].Quntity += quantity;
                }
            }
            PrintOutput(kvp);
        }
        public static void PrintOutput(Dictionary<string, Orders> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.TotalPrice():F2}");
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
            Quntity = quantity;
        }
        public double Price { get; set; }
        public double Quntity { get; set; }

        public double TotalPrice()
        {
            return Price * Quntity;
        }
    }
}
