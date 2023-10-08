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
            int startIndex = 0;
            int endIndex = singleString.Length -1;

            while (startIndex <= endIndex)
            {
                if (startIndex == endIndex)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        Console.Write(singleString[startIndex]);
                    }
                }
                startIndex++;
                endIndex--;
            }
        }
    }
}
