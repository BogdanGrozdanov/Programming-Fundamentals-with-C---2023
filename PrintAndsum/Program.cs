namespace PrintAndsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endtNum = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = startNum; i <= endtNum; i++) { Console.Write(i + " "); sum += i; }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}