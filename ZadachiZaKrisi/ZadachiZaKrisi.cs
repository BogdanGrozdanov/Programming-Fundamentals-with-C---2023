
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
            int start = int.Parse(Console.ReadLine());

            int counterTrue = 0;
            int counterFalse = 0;
            Console.Write("Ще започваме ли?"); string startOrStop = Console.ReadLine();
            while (startOrStop != "да".ToLower() || startOrStop != "da".ToLower())
            {
                for (int i = 1; i <= start; i++)
                {
                    Console.WriteLine($"Задача {i}");
                    Console.WriteLine();

                    Random rnd = new Random();
                    int number1 = rnd.Next(1, 10);  //00
                    int number2 = rnd.Next(1, 10);

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
                        Console.Beep(900,1000);
                        counterFalse++;
                    };
                }
                PrintResult(counterTrue, counterFalse);

                Console.WriteLine("Да продължаваме ли?");
                startOrStop = Console.ReadLine();
            }
            PrintResult(counterTrue, counterFalse);
        }

        private static void PrintResult(int counterTrue, int counterFalse)
        {
            Console.WriteLine("Твоят резултат е:");
            Console.WriteLine($"Грешни отговори {counterFalse}");
            Console.WriteLine($"Вярни отговори {counterTrue}" + Environment.NewLine);
        }
    }
}