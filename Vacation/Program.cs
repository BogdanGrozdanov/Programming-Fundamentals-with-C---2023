namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            //· Type of the group(Students, Business or Regular).
            string typeGruop = Console.ReadLine();
            //· The day of the week which the group will stay on(Friday, Saturday or Sunday).
            string typeOfDay = Console.ReadLine();

            double price = 0;
            double amount = 0;


            if (typeGruop == "Students")
            {
                if (typeOfDay == "Friday") { amount = 8.45 * countPeople; }
                else if (typeOfDay == "Saturday") { amount = 9.80 * countPeople; }
                else if (typeOfDay == "Sunday") { amount = 10.46 * countPeople; }
                if (countPeople >= 30) { amount -= amount * 0.15; }
            }
            else if (typeGruop == "Business")
            {
                if (typeOfDay == "Friday") { amount = 10.90 * countPeople; }
                else if (typeOfDay == "Saturday") { amount = 15.60 * countPeople; }
                else if (typeOfDay == "Sunday") { price = 16; amount = price * countPeople; }
                if (countPeople >= 100) { amount -= price * 10; }
            }
            else if (typeGruop == "Regular")
            {
                if (typeOfDay == "Friday") { amount = 15 * countPeople; }
                else if (typeOfDay == "Saturday") { amount = 20 * countPeople; }
                else if (typeOfDay == "Sunday") { amount = 22.50 * countPeople; }
                if (countPeople >= 10 && countPeople <= 20) { amount -= amount * 0.05; }
            }
            Console.WriteLine($"Total price: {amount:F2}");

        }
    }
}