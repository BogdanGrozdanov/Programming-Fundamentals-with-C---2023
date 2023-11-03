using Microsoft.VisualBasic;

namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> allResourse = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop") { break; }
                int quantity = int.Parse(Console.ReadLine());
                if (!allResourse.ContainsKey(resource))
                {
                    allResourse.Add(resource, quantity);
                }
                else
                {
                    allResourse[resource] += quantity;
                }
            }
            PrintOutputResoursesAndQuantityOfResourses(allResourse);


        }
        public static void PrintOutputResoursesAndQuantityOfResourses
                           (Dictionary<string, int> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
