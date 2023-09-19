namespace BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 30;

            string time = String.Empty;

            if (minute < 60 && hour < 24) { time = $"{hour}:{minute:D2}"; }
            else if (minute >= 60 && hour + 1 <= 23) { time = $"{hour + 1}:{(minute - 60):D2}"; }
            else if (minute >= 60 && hour + 1 > 23) { time = $"{0}:{(minute - 60):D2}"; }

            Console.WriteLine(time);

        }
    }
}