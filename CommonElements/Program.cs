namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondArr = Console.ReadLine().Split().ToArray();

            string[] commonArr = new string[firstArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        commonArr[i] = firstArr[i];
                    }
                }
            }
            for (int i = commonArr.Length - 1; i >= 0; i--)
            { Console.Write(commonArr[i] + " "); }
        }
    }
}
