namespace FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            string[] comand = Console.ReadLine().Split();

            List<string> blackListName = new List<string>();
            while (comand[0] != "Report")
            {
                if (comand[0] == "Blacklist")
                {
                    if (!names.Contains(comand[1]))
                    { Console.WriteLine($"{comand[1]} was not found."); }
                    else 
                    {
                        blackListName.Add(comand[1]);
                        Console.WriteLine($"{comand[1]} was blacklisted.");
                    }
                }
                else if (comand[0] == "Error")
                {

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
        }
    }
}
