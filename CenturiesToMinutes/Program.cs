﻿namespace CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days =(int)( years * 365.2422);
            long hours =(long) days * 24;
            long minutes =(long) hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days:f0} days = {hours} hours = {minutes} minutes");
        }
    }
}
