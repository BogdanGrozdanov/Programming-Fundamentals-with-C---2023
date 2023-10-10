namespace CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double firstPoint = PitagorTheoremDekartCoordinatSystem(x1, y1);
            double secontPoint = PitagorTheoremDekartCoordinatSystem(x2, y2);
            if (firstPoint > secontPoint) { Console.WriteLine($"({x2}, {y2})"); } else { Console.WriteLine($"({x1}, {y1})"); }
            Console.ReadLine();
        }

        static double PitagorTheoremDekartCoordinatSystem(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
    }
}
