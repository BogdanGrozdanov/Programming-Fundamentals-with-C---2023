namespace GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodQuantity = double.Parse(Console.ReadLine());
            double hayQuantiy = double.Parse(Console.ReadLine());
            double coverQuantity = double.Parse(Console.ReadLine());
            double guineaWeight = double.Parse(Console.ReadLine());

            double foodPerMount = 0;
            double hayPerMount = 0;
            double coverPerMount = 0;

            for (int i = 1; i <= 30; i++)
            {

                foodPerMount += 0.300;
                if (i % 2 == 0)
                {
                    hayPerMount += (foodQuantity - foodPerMount) * 0.05;
                }
                coverPerMount = (guineaWeight / 3) * 10;



            }
            if (foodQuantity <= foodPerMount || hayQuantiy <= hayPerMount || coverQuantity <= coverPerMount)
            { Console.WriteLine("Merry must go to the pet store!"); }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodQuantity - foodPerMount):F2}, Hay: {(hayQuantiy - hayPerMount):F2}, Cover: {(coverQuantity - coverPerMount):F2}.");
            }




        }
    }
}
