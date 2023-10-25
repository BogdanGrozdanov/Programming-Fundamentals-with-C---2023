namespace Dice
{
    internal class Dice
    {
        public int Sides { get; set; }
        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, Sides + 1);
        }
    }
}
