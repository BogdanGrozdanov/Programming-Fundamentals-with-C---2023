namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = 0;
            result = GetSumOfEvenDigits(number);
            
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)

                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            return number;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {

            return number;
        }
    }
}
