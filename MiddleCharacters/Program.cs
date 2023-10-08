namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string single = Console.ReadLine();
            MiddleCharacters(single);
        }
        static void MiddleCharacters(string singleString)
        {
            if (singleString.Length % 2 == 0)
            {
                int index = singleString.Length / 2;
                Console.Write(singleString[index - 1]);
                Console.Write(singleString[index]);
            }
            else
            {
                int index = singleString.Length / 2;
                Console.WriteLine(singleString[index]);
            }
        }
    }
}
