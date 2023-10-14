namespace ListManipulationAdvanced
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

            string[] comand = Console.ReadLine().Split();
            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "contains")
                {
                    if (numbers.Contains(int.Parse(comand[1])))
                    { Console.WriteLine("Yes"); }
                    else { Console.WriteLine("No such number"); }
                }
                else if (comand[0].ToLower() == "printeven")
                {
                    foreach (double number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (comand[0].ToLower() == "printodd")
                {
                    foreach (double number in numbers)
                    {
                        if (number % 2 == 1)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (comand[0].ToLower() == "getsum")
                { double sum = numbers.Sum(); Console.WriteLine(sum); }
                else if (comand[0].ToLower() == "filter")
                {
                    string separator = comand[1];
                    double number = double.Parse(comand[2]);

                    if (separator == "<")
                    {
                        foreach (var item in numbers)
                        {
                            if (item < number) { Console.Write(item + " "); }
                        }

                    }
                    else if (separator == ">")
                    {
                        foreach (var item in numbers)
                        {
                            if (item > number) { Console.Write(item + " "); }
                        }
                        Console.WriteLine();
                    }
                    else if (separator == "<=")
                    {
                        foreach (var item in numbers)
                        { if (item <= number) { Console.Write(item + " "); } }
                        Console.WriteLine();
                    }
                    else if (separator == ">=")
                    {
                        foreach (var item in numbers)
                        { if (item >= number) { Console.Write(item + " "); } }
                        Console.WriteLine();
                    }
                }
                comand = Console.ReadLine().Split();
            }
        }
    }
}