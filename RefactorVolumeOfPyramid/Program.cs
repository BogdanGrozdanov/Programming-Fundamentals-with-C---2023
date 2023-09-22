namespace RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double heigth = double.Parse(Console.ReadLine());

            double volume = (length * width * heigth) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
