namespace SpecialNumbers
{
    /* A number is special when its sum of digits is 5, 7 or 11.


    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;

                while (number > 0)
                {
                    int lastDigit = number % 10;
                    sum += lastDigit;
                    number /= 10;
                }
                bool isspecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isspecial}");

            }
        }
    }
}
