using System.Collections.Generic;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bombsNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            int boom = bombsNumber[bomb];
            while (bombsNumber.Contains(bomb))
            {
                int indexBomb = bombsNumber.IndexOf(bomb);
                if (Math.Abs(indexBomb - power) >= 0)
                {
                    for (int i = indexBomb - 1; i >= power; i--)
                    {
                        bombsNumber.Remove(i);
                    }
                }
                else
                {
                    for (int i = indexBomb - 1; i >= 0; i--)
                    {
                        bombsNumber.Remove(i);
                    }
                }
                //
                if (Math.Abs(indexBomb + power) >= bombsNumber.Count - 1)
                {
                    for (int i = indexBomb; i <= bombsNumber.Count; i++)
                    {
                        bombsNumber.Remove(i);
                    }
                }
                else
                {
                    for (int i = indexBomb; i <= bombsNumber.Count - 1; i++)
                    {
                        bombsNumber.Remove(i);
                    }
                }
            }
            int sum = bombsNumber.Sum();
            Console.WriteLine(sum);

            //int indexBomb = bombsNumber.IndexOf(bomb);
            //int leftIndex = Math.Max(0, indexBomb - power);
            //int rightIndex = Math.Min(bombsNumber.Count - 1, indexBomb + power);
            //int range = rightIndex - leftIndex + 1;
            //bombsNumber.RemoveRange(leftIndex, range);



        }
    }
}
