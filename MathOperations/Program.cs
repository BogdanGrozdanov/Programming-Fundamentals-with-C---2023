namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            Calculate(firstNumber, @operator, secondNumber);
        }
        static void Calculate(double firstNumber, string @operator, double secondNumber)
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
