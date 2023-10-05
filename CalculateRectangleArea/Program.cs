using System.Drawing;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = CalculateRectangleArea(a, b);
            Console.WriteLine(area);
        }

        private static int CalculateRectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
