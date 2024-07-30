
using System.Security.Cryptography;
using System.Text;
using static System.Formats.Asn1.AsnWriter;
using System.Media;

namespace ZadachiZaKrisi
{
    internal class ZadachiZaKrisi
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Ще решим ли няколко задачи???");
            Console.WriteLine("Колко на брой да са?");

            int numProblems = int.Parse(Console.ReadLine());

            int counterTrue = 0;//counter
            int counterFalse = 0;//counter

            Console.WriteLine("Ще започваме ли?");
            string startOrStop = Console.ReadLine();

            while (startOrStop != "да".ToLower() || startOrStop != "da".ToLower())
            {
                Random rnd;
                int rangeMinNum, rangeMaxNum;
                RandomNumAndRange(out rnd, out rangeMinNum, out rangeMaxNum);

                for (int i = 1; i <= numProblems; i++)
                {
                    Console.WriteLine($"Задача {i}");
                    Console.WriteLine();

                    int number1 = rnd.Next(rangeMinNum, rangeMaxNum);  //00
                    int number2 = rnd.Next(rangeMinNum, rangeMaxNum);

                    Console.Write($"{number1} + {number2} = ");
                    int result = int.Parse(Console.ReadLine());

                    if (result == number2 + number1)
                    {
                        Console.WriteLine($" Вярно!!!" + Environment.NewLine);

                        Console.Beep(450, 650);

                        counterTrue++;
                    }
                    else
                    {
                        Console.WriteLine(" Грешно" + Environment.NewLine);
                        Console.Beep(900, 1000);
                        counterFalse++;
                    };
                }
                PrintResult(counterTrue, counterFalse);

                Console.WriteLine("Да продължаваме ли?");
                startOrStop = Console.ReadLine();
            }
            PrintResult(counterTrue, counterFalse);
        }

        private static void RandomNumAndRange(out Random rnd, out int rangeMinNum, out int rangeMaxNum)
        {
            rnd = new Random();
            Console.WriteLine("Въведи най малко число ,с което да смятаме... ");
            rangeMinNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи най голямо число ,с което да смятаме... ");
            rangeMaxNum = int.Parse(Console.ReadLine());
            //max number range
        }

        private static void PrintResult(int counterTrue, int counterFalse)
        {
            Console.WriteLine("Твоят резултат е:");
            Console.WriteLine($"Грешни отговори {counterFalse}");
            Console.WriteLine($"Вярни отговори {counterTrue}" + Environment.NewLine);
        }
    }
}