using System.Collections.Immutable;

namespace LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4;
            ReadInput(out x1, out y1, out x2, out y2, out x3, out y3, out x4, out y4);

            double l1 = Pitagor(x1, y1);
            double l2 = Pitagor(x2, y2);
            double l3 = Pitagor(x3, y3);
            double l4 = Pitagor(x4, y4);

            string result = string.Empty;
            string result2 = string.Empty;

            double max2 = 0;
            double[] arr = { x1, y1, x2, y2, x3, y3, x4, y4 };
            double[] max = new double[2];

            if (Pitagor(arr[0], arr[1]) > Pitagor(arr[2], arr[3]))
            {
                max = new double { arr[0] arr[1] } ;
            }




            Console.WriteLine(string.Join(" ", arr));
            //if (Pitagor(x1, y1) > Pitagor(x2, y2))
            //{
            //    max = Pitagor(x1, y1);
            //    result = $"({x1}, {y1})";
            //}
            //else
            //{
            //    max = Pitagor(x2, y2);
            //    result = $"({x2}, {y2})";
            //}


            //if (Pitagor(x3, y3) > Pitagor(x4, y4))
            //{
            //    max2 = Pitagor(x3, y3);
            //    result2 = $"({x3}, {y3})";
            //}
            //else
            //{
            //    max2 += Pitagor(x4, y4);
            //    result2 = $"({x4}, {y4})";
            //}
        }

        static void ReadInput(out double x1, out double y1, out double x2, out double y2, out double x3, out double y3, out double x4, out double y4)
        {
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
        }

        static double Pitagor(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
    }
}
