namespace TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();

            long leftDamage = CalculateDamage(prices, 0, entryPoint, itemType);
            long rightDamage = CalculateDamage(prices, entryPoint + 1, prices.Length, itemType);

            if (leftDamage >= rightDamage)
            {
                Console.WriteLine($"Left - {leftDamage}");
            }
            else
            {
                Console.WriteLine($"Right - {rightDamage}");
            }
        }

        static long CalculateDamage(int[] prices, int start, int end, string itemType)
        {
            long damage = 0;
            int entryPointValue = prices[start];

            if (itemType == "cheap")
            {
                for (int i = start; i < end; i++)
                {
                    if (prices[i] < entryPointValue)
                    {
                        damage += prices[i];
                    }
                }
            }
            else if (itemType == "expensive")
            {
                for (int i = start; i < end; i++)
                {
                    if (prices[i] >= entryPointValue)
                    {
                        damage += prices[i];
                    }
                }
            }

            return damage;
        }
    }

}
