namespace SpecialNumbers
{
    /* A number is special when its sum of digits is 5, 7 or 11.


    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            bool isSpesial = true;
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(i);
            }
        }
    }
}
