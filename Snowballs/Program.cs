using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowball = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int highestSnowballSnow = 0;
            int highestSnowballTime = 0;
            int highestSnowballQuality = 0;

            for (int i = 0; i < numberOfSnowball; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValueM = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue < snowballValueM) { snowballValue = snowballValueM; highestSnowballSnow = snowballSnow; highestSnowballTime = snowballTime; highestSnowballQuality = snowballQuality; }
            }
            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {snowballValue} ({highestSnowballQuality})");
        }
    }
}
