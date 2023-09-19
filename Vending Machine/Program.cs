using System.Security.Claims;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double reciveCoin = 0;
            while (input != "Start")
            {
                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    reciveCoin += double.Parse(input);
                }
                else { Console.WriteLine($"Cannot accept {input}"); }
                input = Console.ReadLine();
                if (input == "End") { break; }
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Nuts" || input == "Water" || input == "Crisps" || input == "Soda" || input == "Coke")
                {
                    switch (input)
                    {
                        case "Nuts": if (reciveCoin >= 2) { reciveCoin -= 2; Console.WriteLine("Purchased nuts"); } else { Console.WriteLine("Sorry, not enough money"); }; break;
                        case "Water": if (reciveCoin >= 0.7) { reciveCoin -= 0.7; Console.WriteLine("Purchased water"); } else { Console.WriteLine("Sorry, not enough money"); }; break;
                        case "Crisps": if (reciveCoin >= 1.5) { reciveCoin -= 1.5; Console.WriteLine("Purchased crisps"); } else { Console.WriteLine("Sorry, not enough money"); }; break;
                        case "Soda": if (reciveCoin >= 0.8) { reciveCoin -= 0.8; Console.WriteLine("Purchased soda"); } else { Console.WriteLine("Sorry, not enough money"); }; break;
                        case "Coke": if (reciveCoin >= 1) { reciveCoin -= 1; Console.WriteLine("Purchased coke"); } else { Console.WriteLine("Sorry, not enough money"); }; break;
                    }
                }
                else { Console.WriteLine("Invalid product"); }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {reciveCoin:F2}");

        }
    }
}