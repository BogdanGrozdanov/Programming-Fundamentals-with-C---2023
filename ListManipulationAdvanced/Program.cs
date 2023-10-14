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
            ListManipulationAdvans(numbers);

        }

        static void ListManipulationAdvans(List<double> numbers)
        {
            string[] comand = Console.ReadLine().Split();
            int couter = 0;
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

                if (comand[0].ToLower() == "add")
                {
                    numbers.Add(int.Parse(comand[1]));
                    couter++;
                }
                else if (comand[0].ToLower() == "remove")
                {
                    numbers.Remove(int.Parse(comand[1]));
                    couter++;
                }
                else if (comand[0].ToLower() == "removeat")
                {
                    numbers.RemoveAt(int.Parse(comand[1]));
                    couter++;
                }
                else if (comand[0].ToLower() == "insert")
                {
                    numbers.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                    couter++;
                }
                comand = Console.ReadLine().Split();
            }
            if (couter > 0) { Console.WriteLine(string.Join(" ", numbers)); }
        }


    }
}