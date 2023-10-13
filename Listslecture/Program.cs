using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace Listslecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            List<int> number2 = new List<int> { 1, 2, 3, 4 };
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            number.Add(1);
            number.Add(2);
            number.Count();
            List<int> numbers4 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers4.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
