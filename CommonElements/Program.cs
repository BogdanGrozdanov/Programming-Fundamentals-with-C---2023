namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondArr = Console.ReadLine().Split().ToArray();

            string[] commonArr = new string[firstArr.Length];

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        { Console.Write(secondArr[i] + " "); }
                        break;
                    }
                }
            }
        }
    }
}
