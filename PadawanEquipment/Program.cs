using System.Drawing;
using System.Reflection.Emit;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightSabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            //
            double ligtsaber = lightSabersPrice * (studentCount + Math.Ceiling(studentCount * 0.1));
            double robe = studentCount * robePrice;
            double belt = (studentCount - (studentCount / 6)) * beltPrice;
            double amount = ligtsaber + robe + belt;
            //
            if (amount <= budget) { Console.WriteLine($"The money is enough - it would cost {amount:F2}lv."); }
            else { Console.WriteLine($"John will need {amount -budget:F2}lv more."); }
            //Console.WriteLine(6/6);
            //· All prices must be rounded to two digits after the decimal point.
        }
    }
}