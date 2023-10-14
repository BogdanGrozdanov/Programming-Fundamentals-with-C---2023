namespace RemoveNegativesAndReverse
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
            List<double> outputNumbers = new List<double>();
            foreach (double number in numbers) { if (number >= 0) { outputNumbers.Add(number); } }
            //for (int i = numbers.Count - 1; i > 0; i--)
            //{
            //    if (numbers[i] >= 0) { Console.Write(numbers[i] + " "); }
            //}
            outputNumbers.Reverse();
            if (outputNumbers.Count == 0) { Console.WriteLine("empty"); }
            else { Console.WriteLine(string.Join(" ", outputNumbers)); }

        }
    }
}
