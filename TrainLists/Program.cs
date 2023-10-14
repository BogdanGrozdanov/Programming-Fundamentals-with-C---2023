namespace TrainLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] comand = Console.ReadLine().Split();
            while (comand[0] != "end")
            {
                if (comand[0].ToLower() == "add")
                {
                    wagons.Add(int.Parse(comand[1]));
                }
                else
                {
                    int numberOfPassenger = int.Parse(comand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (numberOfPassenger + wagons[i] <= capacity)
                        {
                            wagons[i] = numberOfPassenger + wagons[i];
                            break;
                        }
                    }
                }
                comand = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
