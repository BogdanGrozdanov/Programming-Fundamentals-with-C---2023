namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int num = int.Parse(Console.ReadLine());

            if (num < 0 || num > dayOfWeek.Length) { Console.WriteLine("Invalid day"); }
            else { Console.WriteLine(dayOfWeek[num - 1]); }
        }
    }
}
