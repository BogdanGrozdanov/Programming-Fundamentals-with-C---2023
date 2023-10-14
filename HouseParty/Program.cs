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
                if (names.Contains(name[0]))
                {
                    Console.WriteLine($"{name[0]} is already in the list!");
                }
                else if (name[2] == "")
                {
                    names.Add(name[0]);
                }
            }
            for (int i = 0; i < names.Count; i++)
            {

            }
        }
    }
}
