namespace CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string[] comand = Console.ReadLine().Split();
            bool flag = false;
            int counter = 0;

            while (!comand.Contains("End"))
            {
                int distance = int.Parse(comand[0]);
                if (distance <= initialEnergy)
                {
                    counter++;
                    initialEnergy -= distance;
                    if (counter % 3 == 0) { initialEnergy += counter; }
                }
                else
                {
                    flag = true;
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {initialEnergy} energy.");
                    break;
                }
                comand = Console.ReadLine().Split();
            }

            if (!flag) { Console.WriteLine($"Won battles: {counter}. Energy left: {initialEnergy}"); }
        }
    }
}