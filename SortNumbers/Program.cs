namespace SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            numbers.Sort();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}