namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rotationCount = int.Parse(Console.ReadLine());

            string[] arr = Console.ReadLine().Split();
            string[] curentArr = new string[arr.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                curentArr[i] = arr[arr.Length - 1];
                for (int j = 0; j < arr.Length; j++)
                {

                }
                arr[i] = curentArr[i];
                ;
            }

        }
    }
}
