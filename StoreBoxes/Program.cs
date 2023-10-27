namespace StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Box> boxes = new List<Box>();
            while (input[0] != "end")
            {
                int serialNumber = int.Parse(input[0]);
                string itemName = input[1];
                int quantityItem = int.Parse(input[2]);
                decimal priceItem = decimal.Parse(input[3]);

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item.Name = itemName;
                box.Quantity = quantityItem;
                box.Item.Price = priceItem;
                box.PriceBox = priceItem * quantityItem;
                boxes.Add(box);

                input = Console.ReadLine().Split();
            }
            List<Box> sortBoxes = boxes.OrderByDescending(b => b.PriceBox).ToList();
            PrintOutput(sortBoxes);
        }

        public static void PrintOutput(List<Box> sortBoxes)
        {
            foreach (Box box in sortBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:F2}");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }

    }
}
