namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(" ");
            int rotationNum = int.Parse(Console.ReadLine());


            for (int i = 0; i < rotationNum; i++)
            {
                string rotationElement = inputArr[0];

                for (int j = 1; j < inputArr.Length; j++)
                {
                    string currentElement = inputArr[j];
                    inputArr[j - 1] = currentElement;
                }
                inputArr[inputArr.Length - 1] = rotationElement;

            }
            Console.WriteLine(string.Join(" ", inputArr));
        }
    }
}
