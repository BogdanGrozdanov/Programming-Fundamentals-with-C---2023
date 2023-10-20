namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] numWagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityWagons = 4;

            for (int i = 0; i < numWagons.Length; i++)
            {
                if (numWagons[i] < 4)
                {
                    int peopleAdd = capacityWagons - numWagons[i];
                    if (people < capacityWagons)
                    {
                        peopleAdd = people;
                    }
                    numWagons[i] += peopleAdd;
                    people -= numWagons[i];
                }
            }

            for (int i = 0; i < numWagons.Length; i++)
            {
                if (numWagons[i] < capacityWagons)
                {
                    Console.WriteLine($"The lift has empty spots!{string.Join(" ", numWagons)}");
                }
            }

            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!{string.Join(" ", numWagons)}");

            }
        }
    }
}
