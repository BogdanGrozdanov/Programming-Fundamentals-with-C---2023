using System.Collections.Generic;
using System.Drawing;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lostGameCount = int.Parse(Console.ReadLine());
            double priceHeadsets = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            //
            //expenses
            double money = priceHeadsets * (lostGameCount / 2);
            money += priceMouse * (lostGameCount / 3); ;
            money += priceKeyboard * (lostGameCount / 6);
            money += priceDisplay * (lostGameCount / 12);

            Console.WriteLine($"Rage expenses: {money:F2} lv.");

        }
    }
}