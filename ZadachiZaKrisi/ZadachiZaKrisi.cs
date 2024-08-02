
using System.Text;

namespace ZadachiZaKrisi
{
    internal class ZadachiZaKrisi
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Ще решим ли няколко задачи???");
            Console.WriteLine("Колко на брой да са?");

            int numProblems = int.Parse(Console.ReadLine());//

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

                    Console.WriteLine("С какво действие да бъдат ...");
                    string action = Console.ReadLine();

                    PrintProblemForResolve(number1, number2, action);

                    int result = int.Parse(Console.ReadLine());

                    if (action == "+")
                    {
                        AddMethod(ref counterTrue, ref counterFalse, number1, number2, result);
                    }
                    else if (action == "*")
                    {
                        MultyplayMethod(ref counterTrue, ref counterFalse, number1, number2, result);
                    }
                    else if (action == "-")
                    {
                        SubstractMethod(ref counterTrue, ref counterFalse, number1, number2, result);
                    }
                    else if (action == "/")
                    {
                        DivideMethod(ref counterTrue, ref counterFalse, number1, number2, result);
                    }
                }


                PrintResult(counterTrue, counterFalse);

                Console.WriteLine("Да продължаваме ли?");
                startOrStop = Console.ReadLine();
            }
        }

        static void DivideMethod(ref int counterTrue, ref int counterFalse, int number1, int number2, int result)
        {
            if (number1 >= number2)
            {
                if (result == number1 / number2)
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
                }
            }
            else
            {
                if (result == number2 / number1)
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
                }
            }
        }
        static void PrintProblemForResolve(int number1, int number2, string action)
        {
            if (action == "-" || action == "/")
            {
                if (number1 >= number2)
                {
                    Console.Write($"{number1} {action} {number2} = ");
                }
                else
                {
                    Console.Write($"{number2} {action} {number1} = ");
                }
            }
            else
            {
                Console.Write($"{number1} {action} {number2} = ");
            }
        }
        static void SubstractMethod(ref int counterTrue, ref int counterFalse, int number1, int number2, int result)
        {
            if (number1 >= number2)
            {
                if (result == number1 - number2)
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
                }
            }
            else
            {
                if (result == number2 - number1)
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
                }
            }
        }
        static void MultyplayMethod(ref int counterTrue, ref int counterFalse, int number1, int number2, int result)
        {
            if (result == number2 * number1)
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
            }
        }
        static void RandomNumAndRange(out Random rnd, out int rangeMinNum, out int rangeMaxNum)
        {
            rnd = new Random();
            Console.WriteLine("Въведи най малко число ,с което да смятаме... ");
            rangeMinNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи най голямо число ,с което да смятаме... ");
            rangeMaxNum = int.Parse(Console.ReadLine());
            //max number range
        }
        static void PrintResult(int counterTrue, int counterFalse)
        {
            Console.WriteLine("Твоят резултат е:");
            Console.WriteLine($"Грешни отговори {counterFalse}");
            Console.WriteLine($"Вярни отговори {counterTrue}" + Environment.NewLine);
        }
        static void AddMethod(ref int counterTrue, ref int counterFalse, int number1, int number2, int result)
        {
            if (result == number1 + number2)
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
    }
}