namespace Dice
{
    internal class Dice
    {
        public Dice(int sides)
        {
            Sides = sides;
        }
        public int Sides { get; set; }
        public string Type { get; set; }
        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, Sides + 1);
        }
    }
}
