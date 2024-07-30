using System.Numerics;

namespace AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            BigInteger command = BigInteger.Parse(Console.ReadLine());

            for (BigInteger i = 1; i <= command; i += 1)
            {
                Console.Write(i + 1 + " ");
            }



            //while (command != "End")
            //{

            //    if (command == "+")
            //    {
            //        Console.Write("Enter a number 1 :");
            //        int num1 = int.Parse(Console.ReadLine());
            //        Console.Write("Enter a number 2 :");
            //        int num2 = int.Parse(Console.ReadLine());
            //        result = num1 + num2; //result
            //    }
            //    else if (command == "Bogdan")
            //    {
            //        Console.WriteLine("Is my dad");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Simona");
            //    }
            //    Console.WriteLine($"Result is : {result} ");
            //    result = 0;
            //    Console.Write("Enter a command :");
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine("Program ended!");
        }
    }
}
