namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bombsNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < bombsNumber.Count; i++)
            {
               
               
            }
        }
    }
}
