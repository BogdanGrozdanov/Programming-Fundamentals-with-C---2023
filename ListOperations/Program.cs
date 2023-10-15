namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intergers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split();
            while (comand[0].ToLower() != "end")
            {
                if (comand[0].ToLower() == "add")
                {
                    intergers.Add(int.Parse(comand[1]));
                }
                else if (comand[0].ToLower() == "insert")
                {
                    if (int.Parse(comand[2]) > intergers.Count - 1 || int.Parse(comand[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    intergers.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }
                else if (comand[0].ToLower() == "remove")
                {
                    if (int.Parse(comand[1]) > intergers.Count - 1 || int.Parse(comand[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else { intergers.RemoveAt(int.Parse(comand[1])); }

                }
                else if (comand[0].ToLower() == "shift" && comand[1].ToLower() == "left")
                {
                    for (int i = 0; i < int.Parse(comand[2]); i++)
                    {
                        int movedElement = intergers[0];
                        intergers.RemoveAt(0);
                        intergers.Add(movedElement);
                    }
                }
                else if (comand[0].ToLower() == "shift" && comand[1].ToLower() == "right")
                {
                    int lastElement = intergers.Last();
                    intergers.RemoveAt(intergers.Count - 1);
                    intergers.Insert(0, lastElement);
                }
                comand = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", intergers));
        }
    }
}
