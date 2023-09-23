namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int index = 0;
            bool isEqual = default;
            for (int i = 0; i < firstArr.Length; i++)
            {

                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    isEqual = true;
                    break;
                }
                index++;
                sum += firstArr[i];
            }
            if (!isEqual) { Console.WriteLine($"Arrays are identical. Sum: {sum}"); }
        }
    }
}
