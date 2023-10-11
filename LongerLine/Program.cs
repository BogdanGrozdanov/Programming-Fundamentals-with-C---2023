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

            string result1 = string.Empty;
            string result2 = string.Empty;
            double max1 = 0;
            double max2 = 0;

            if (l1 > l2)
            {
                max1 = l2;
                result1 = $"({x2}, {y2})";
            }
            else
            {
                max1 = l1;
                result1 = $"({x1}, {y1})";
            }

            if (l3 > l4)
            {
                max2 = l4;
                result2 = $"({x4}, {y4})";
            }
            else
            {
                max2 = l3;
                result2 = $"({x3}, {y3})";
            }

            if (max1 < max2)
            {
                Console.WriteLine(result1);
                Console.WriteLine(result2);
            }
            else
            {
                Console.WriteLine(result2);
                Console.WriteLine(result1);
            }
        }
        static double PitagorTheoremDekartCoordinatSystem(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
    }
}
