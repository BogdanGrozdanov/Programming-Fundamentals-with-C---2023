namespace ListManipulationAdvanced
{
    internal class Program
    {/*· Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".

      · PrintEven – print all the even numbers, separated by a space.

      · PrintOdd – print all the odd numbers, separated by a space.

     · GetSum – print the sum of all the numbers.

       · Filter {condition} {number} – print all the numbers that fulfill the given condition. The condition will be either '<', '>', ">=", "<=".
        */
        static void Main(string[] args)
        {
            List<double> numbers =
                 Console.ReadLine()
                 .Split().
                 Select(double.Parse)
                 .ToList();

            string[] comand = Console.ReadLine().Split();
            while (comand[0] != "end")
            {
                if (comand[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(comand[1]))) { Console.WriteLine("Yes"); }
                    else { Console.WriteLine("Nosuch number"); }
                }
                else if (comand[0] == "PrintEven")
                {
                    foreach (double number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
                else if (comand[0] == "PrintOdd")
                {
                    foreach (double number in numbers)
                    {
                        if (number % 2 == 1)
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
                else if (comand[0] == "GetSum")
                { double sum = numbers.Sum(); Console.WriteLine(sum); }
                else if (comand[0] == "Filter")
                {
                    string separator = comand[1];
                    double number = double.Parse(comand[2]);
                    if (separator == "<")
                    {
                        foreach (var item in numbers)
                        {
                            if (item < number) { Console.WriteLine(item + " "); }
                        }
                    }
                    else if (separator == ">")
                    {
                        foreach (var item in numbers)
                        {
                            if (item > number) { Console.WriteLine(item + " "); }
                        }
                    }
                    else if (separator == "<=")
                    {
                        foreach (var item in numbers)
                        { if (item <= number) { Console.WriteLine(item + " "); } }

                    }
                    comand = Console.ReadLine().Split();
                }
            }
        }
    }
}