
namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintingTriangle(number);
        }

        static void PrintingTriangle(int number)
        {
            for (int i = 1; i <= number; i++) 
            { Console.WriteLine(i);
                
            }
        }
    }
}
