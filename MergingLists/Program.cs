﻿using System.ComponentModel.Design;
using System.Globalization;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> firstNumbers =
                Console.ReadLine()
                .Split().
                Select(double.Parse)
                .ToList();
            List<double> secondNumbers =
                Console.ReadLine()
                .Split().
                Select(double.Parse)
                .ToList();
            List<double> outputList = new List<double>();

            int endLooping = 0;

            if (firstNumbers.Count < secondNumbers.Count)
            { endLooping = firstNumbers.Count; }
            else { endLooping = secondNumbers.Count; }

            for (int i = 0; i < endLooping; i++)
            {
                outputList.Add(firstNumbers[i]);
                outputList.Add(secondNumbers[i]);
            }
            if (firstNumbers.Count < secondNumbers.Count)
            {
                for (int i = endLooping; i < secondNumbers.Count; i++)
                { outputList.Add(secondNumbers[i]); }
            }
            else
            {
                for (int i = endLooping; i < firstNumbers.Count; i++)
                { outputList.Add(firstNumbers[i]); }
            }

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
