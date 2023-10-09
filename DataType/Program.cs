namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    MultiplayIntegerX2();
                    break;
                case "real":
                    FormatToSecondDecimalPoint();
                    break;
                case "string":
                    AddSymboltoSring();
                    break;
            }
        }

        static void AddSymboltoSring()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"${input}$");
        }

        static void FormatToSecondDecimalPoint()
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(number * 1.5):F2}");
        }

        static void MultiplayIntegerX2()
        {
            int number = int.Parse(Console.ReadLine());
            number *= 2;
            Console.WriteLine(number);
        }
    }
}
