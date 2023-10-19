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
            while (foodPerMount >= foodQuantity && hayQuantiy <= hayPerMount && coverQuantity <= coverPerMount)
            {
                //if (foodPerMount >= foodQuantity && hayQuantiy <= hayPerMount && coverQuantity <= coverPerMount)
                //{
                //    Console.WriteLine("Merry must go to the pet store!");
                //    break;
                //}
                for (int i = 1; i <= 30; i++)
                {
                    foodPerMount += 0.3;
                    if (i % 2 == 0)
                    {
                        hayPerMount = (foodQuantity - foodPerMount) - 0.05;
                    }
                    if (i % 3 == 0)
                    {
                        coverPerMount = guineaWeight / 3.0;
                    }
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQuantity - foodPerMount:F2}, Hay: {hayQuantiy - hayPerMount:F2}, Cover: {coverQuantity - coverPerMount:2}.");


        }
    }
}
