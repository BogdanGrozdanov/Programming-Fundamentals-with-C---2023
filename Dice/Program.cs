namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            dice.Sides = 6;
            int result = dice.Roll();
            Console.WriteLine(result);
        }
    }
}
