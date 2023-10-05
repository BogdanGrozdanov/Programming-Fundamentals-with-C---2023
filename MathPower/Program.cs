namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = Math.Pow(baseNumber, power);
            Console.WriteLine(result);
        }
    }
}
