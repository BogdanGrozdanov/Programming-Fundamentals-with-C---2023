﻿using System.ComponentModel.Design;

namespace TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());

            if (typeDay == "Weekday")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122) { Console.WriteLine("12$"); }
                else if (age > 18 && age <= 64) { Console.WriteLine("18$"); }
                else { Console.WriteLine("Error!"); }
            }
            else if (typeDay == "Weekend")
            {
                if (age >= 0 && age <= 18 || age > 64 && age <= 122) { Console.WriteLine("15$"); }
                else if (age > 18 && age <= 64) { Console.WriteLine("20$"); }
                else { Console.WriteLine("Error!"); }
            }
            else if (typeDay == "Holiday")
            {
                if (age >= 0 && age <= 18) { Console.WriteLine("5$"); }
                else if (age > 18 && age <= 64) { Console.WriteLine("12$"); }
                else if (age > 64 && age <= 122) { Console.WriteLine("10$"); }
                else { Console.WriteLine("Error!"); }
            }
            else { Console.WriteLine("Error!"); }
        }
    }
}