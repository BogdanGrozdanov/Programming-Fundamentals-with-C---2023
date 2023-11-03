namespace AssociativeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (double d in numbers)
            {
                if (!count.ContainsKey(d))
                {
                    count.Add(d, 1);
                }
                else
                {
                    count[d]++;
                }
            }

            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
