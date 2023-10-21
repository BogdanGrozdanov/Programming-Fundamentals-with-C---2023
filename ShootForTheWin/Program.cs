using System.Diagnostics.Metrics;

namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string comand = Console.ReadLine();
            int counter = 0;
            while (comand != "End")
            {
                int index = int.Parse(comand);

                if (targets.Count - 1 >= index)
                {

                    var curentElement = targets[index];

                    targets[index] = -1;
                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] >= 0 && targets[i] > curentElement) { targets[i] -= curentElement; counter++; }
                        else if (targets[i] >= 0 && targets[i] <= curentElement) { targets[i] += curentElement; counter++; }
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}