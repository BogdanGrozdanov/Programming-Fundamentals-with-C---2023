using System.Collections.Generic;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] name = Console.ReadLine().Split(" ");

                if (name[2] == "not")
                {
                    if (names.Contains(name[0])) { names.Remove(name[0]); }
                    else { Console.WriteLine($"{name[0]} is not in the list!"); }
                }
                else if (names.Contains(name[0]))
                {
                    Console.WriteLine($"{name[0]} is already in the list!");
                }
                else { names.Add(name[0]); }
            }
            foreach (string name in names) { Console.WriteLine(name); }

        }
    }
}
