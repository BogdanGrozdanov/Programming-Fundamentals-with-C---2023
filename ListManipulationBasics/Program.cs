namespace ListManipulationBasics
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
            ChangesList(numbers);
        }

         static void ChangesList(List<double> numbers)
        {
            string[] comand = Console.ReadLine().Split();
            while (comand[0] != "end")
            {
                if (comand[0] == "Add")
                {
                    numbers.Add(int.Parse(comand[1]));
                }
                else if (comand[0] == "Remove")
                {
                    numbers.Remove(int.Parse(comand[1]));
                }
                else if (comand[0] == "RemoveAt")
                { numbers.RemoveAt(int.Parse(comand[1])); }
                else if (comand[0] == "Insert")
                { numbers.Insert(int.Parse(comand[2]), int.Parse(comand[1])); }

                comand = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
