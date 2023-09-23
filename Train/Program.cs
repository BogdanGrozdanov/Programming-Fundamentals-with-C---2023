namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in arr) { Console.Write(i + " "); }
            Console.WriteLine();
            Console.WriteLine(arr.Sum());
        }
    }
}
