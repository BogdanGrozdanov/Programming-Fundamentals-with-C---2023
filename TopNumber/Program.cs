namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopInteger(n);
        }

        static void PrintTopInteger(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsTopNumber(int number)
        {
            if (IsDivisibleBy8(number) && ContainsOddDigit(number))
            {
                return true;
            }

            return false;
        }

        static bool IsDivisibleBy8(int number)
        {
            int sumOfDigits = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            return sumOfDigits % 8 == 0;
        }

        static bool ContainsOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }
    }
}
