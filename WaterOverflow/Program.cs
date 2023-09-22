namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int sumWater = 0;

            for (int i = 0; i < n; i++)
            {
                int water = int.Parse(Console.ReadLine());
                sumWater += water;

                if (capacity < sumWater) { Console.WriteLine("Insufficient capacity!"); sumWater -= water; }
            }
            Console.WriteLine(sumWater);
        }
    }
}
