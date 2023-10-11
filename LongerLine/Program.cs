using System.Collections.Immutable;

namespace LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double l1 = PitagorTheoremDekartCoordinatSystem(x1, y1);
            double l2 = PitagorTheoremDekartCoordinatSystem(x2, y2);
            double l3 = PitagorTheoremDekartCoordinatSystem(x3, y3);
            double l4 = PitagorTheoremDekartCoordinatSystem(x4, y4);

            string result =string.Empty;
            double max
            if (l1 > l2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            if (l3 > l4)
            {
                Console.WriteLine($"({x4}, {y4})");
            }
            else
            {
                Console.WriteLine($"({x3}, {y3})");
            }
        }
        static double PitagorTheoremDekartCoordinatSystem(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
    }
}
