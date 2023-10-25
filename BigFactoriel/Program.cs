using System.Numerics;

namespace BigFactoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            for (int i = 1; i <= number; i++)
            { factoriel *= i; }
            Console.WriteLine(factoriel);
        }
    }
}
