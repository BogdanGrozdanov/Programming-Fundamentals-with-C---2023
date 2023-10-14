namespace ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split();
            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (int.Parse(comand[1]) == numbers[i]) { numbers.Remove(int.Parse(comand[1])); }
                    }
                }
                else if (comand[0].ToLower() == "insert")
                {
                    int index = int.Parse(comand[2]);
                    int element = int.Parse(comand[1]);
                    numbers.Insert(index, element);
                }
                comand = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
