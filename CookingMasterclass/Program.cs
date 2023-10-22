namespace CookingMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPricePerPack = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double singleApromPrice = double.Parse(Console.ReadLine());
            // Calculation
            int freeFlour = students / 5;
            double allFlour = (students - freeFlour) * flourPricePerPack;
            double allEggs = students * singleEggPrice * 10;
            double allAprom = (Math.Ceiling(students * 0.2) + students) * singleApromPrice;

            double totalAmount = allFlour + allEggs + allAprom;

            if (budget >= totalAmount)
            {
                Console.WriteLine($"Items purchased for {totalAmount:F2}$.");
            }
            else if (budget < totalAmount)
            {
                Console.WriteLine($"{(totalAmount - budget):F2}$ more needed.");
            }

        }

    }
}
