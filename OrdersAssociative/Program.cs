namespace OrdersAssociative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> kvp = new Dictionary<string, double>();

            while (true)
            {
                string[] orders = InputStringsArray();
                if (orders[0] == "buy") { break; }
                string item = orders[0];
                double price = double.Parse(orders[1]);
                double quantity = double.Parse(orders[2]);
                if (!kvp.ContainsKey(item))
                {
                    kvp.Add(item, price * quantity);
                }
                else
                {
                    kvp[item] += price * quantity;
                }
            }
            PrintOutput(kvp);

        }
        public static void PrintOutput
                           (Dictionary<string, double> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
        public static string[] InputStringsArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}
