
namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());

            double result = Factoriel(firstInteger) / Factoriel(secondInteger);
            Console.WriteLine($"{result:F2}");
        }

        static int Factoriel(int firstInteger)
        {
            int factoriel = 1;

            for (int i = 1; i <= firstInteger; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
