namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = InputStringsArray();

            Dictionary<char, int> strings = new Dictionary<char, int>();
            InputAndCountDiferentChars(inputString, strings);
            PrintOutputCountCharsInStrings(strings);
        }

        public static void PrintOutputCountCharsInStrings(Dictionary<char, int> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        public static void InputAndCountDiferentChars(string[] inputString, Dictionary<char, int> strings)
        {
            foreach (string input in inputString)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!strings.ContainsKey(input[i]))
                    {
                        strings.Add(input[i], 1);
                    }
                    else
                    {
                        strings[input[i]]++;
                    }
                }
            }
        }

        public static string[] InputStringsArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
        }
    }
}
