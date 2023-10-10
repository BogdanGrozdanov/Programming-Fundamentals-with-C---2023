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

            double[] firstPoint = { x1, y1 };
            double[] secondPoint = { x2, y2 };
            double[] thirthPoint = { x3, y3 };
            double[] fourPoint = { x4, y4 };

            double l1 = PitagorTheoremDekartCoordinatSystem(firstPoint[0], firstPoint[1]);
            double l2 = PitagorTheoremDekartCoordinatSystem(secondPoint[0], secondPoint[1]);
            double l3 = PitagorTheoremDekartCoordinatSystem(thirthPoint[0], thirthPoint[1]);
            double l4 = PitagorTheoremDekartCoordinatSystem(fourPoint[0], fourPoint[1]);

            double[] arangedArrayByOrder = new double[3];
            for (int i = 0; i < arangedArrayByOrder.Length; i++)
            { 
            
            }




        }



        static double GetMax(double a, double b)
        {
            if (a.CompareTo(b) > 0) { return a; } else { return b; }
        }


        static double PitagorTheoremDekartCoordinatSystem(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
    }
}
