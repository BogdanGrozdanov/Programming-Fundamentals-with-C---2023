namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(200);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(dice.Roll());
            }

        }
    }
}
