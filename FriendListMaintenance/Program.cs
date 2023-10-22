namespace FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            string[] comand = Console.ReadLine().Split();

            List<string> blackListName = new List<string>();
            int lostCounterName = 0;
            int blacklistedCounter = 0;
            while (comand[0] != "Report")
            {
                if (comand[0] == "Blacklist")
                {
                    if (!names.Contains(comand[1]))
                    { Console.WriteLine($"{comand[1]} was not found."); }
                    else
                    {
                        int indexToChange = names.IndexOf(comand[1]);
                        names[indexToChange] = "Blacklisted";
                        Console.WriteLine($"{comand[1]} was blacklisted.");
                        blacklistedCounter++;
                    }
                }
                else if (comand[0] == "Error")
                {
                    if (int.Parse(comand[1]) < names.Count)//index valid
                    {
                        string name = names[int.Parse(comand[1])];
                        if (name != "Lost" && name != "Blacklisted")
                        {
                            Console.WriteLine($"{name} was lost due to an error.");
                            names[int.Parse(comand[1])] = "Lost";
                            lostCounterName++;
                        }

                    }
                }
                else if (comand[0] == "Change")
                {
                    if (int.Parse(comand[1]) < names.Count)
                    {
                        string curentName = names[int.Parse(comand[1])];
                        names[int.Parse(comand[1])] = comand[2];
                        Console.WriteLine($"{curentName} changed his username to {comand[2]}.");
                    }
                }
                comand = Console.ReadLine().Split();
            }
            Console.WriteLine($"Blacklisted names: {blacklistedCounter}");
            Console.WriteLine($"Lost names: {lostCounterName}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
