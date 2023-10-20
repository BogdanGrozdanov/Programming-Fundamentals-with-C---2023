namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] numWagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numWagons.Length; i++)
            {
                if (numWagons[i] < 4)
                {
                    
                    numWagons[i] += people;
                    people--;
                }
            }
            if (numWagons.Contains(3))
            {
                Console.WriteLine($"The lift has empty spots!{string.Join(" ", numWagons)}");
            }
            if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!{string.Join(" ", numWagons)}");

            }
        }
    }
}
