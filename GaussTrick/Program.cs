namespace GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers =
                Console.ReadLine()
                .Split().
                Select(double.Parse)
                .ToList();

            List<double> sumNumbers = new List<double>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                double left = numbers[i];
                double right = numbers[numbers.Count - 1 - i];
                sumNumbers.Add(left + right);
            }
            if (numbers.Count % 2 == 1)
            {
                sumNumbers.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", sumNumbers));

        }
    }
}
