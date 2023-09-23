namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            if (arrInput.Length == 1)
            {
                Console.WriteLine(arrInput[0]);
                return;
            }
            else
            {
                while (arrInput.Length != 1)
                {
                    int[] condensed = new int[arrInput.Length - 1];
                    for (int i = 0; i < arrInput.Length - 1; i++)
                    {
                        condensed[i] = arrInput[i] + arrInput[i + 1];
                    }
                    arrInput = condensed;
                }
            }
            Console.WriteLine(arrInput[0]);
        }
    }
}
