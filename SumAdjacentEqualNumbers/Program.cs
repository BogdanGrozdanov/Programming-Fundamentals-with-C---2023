using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SumAdjacentEqualNumbers(numbers);
            Console.WriteLine(string.Join(" ", numbers.ToArray()));
        }

        static void SumAdjacentEqualNumbers(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    double curentSum = numbers[i] + numbers[i + 1];
                    numbers.Remove(numbers[i]);
                    numbers.Remove(numbers[i]);
                    numbers.Insert(i, curentSum);
                    i = -1;
                }
            }
        }
    }
}
