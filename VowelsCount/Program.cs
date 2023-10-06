namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CountVowels(input);
        }

        static void CountVowels(string input)
        {
            int counter = 0;
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }

    }
}
