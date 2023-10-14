namespace ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> productList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                productList.Add(input);
            }
            productList.Sort();
            for (int i = 0;i < productList.Count;i++) 
            { Console.WriteLine($"{i+1}.{productList[i]}"); }
        }
    }
}
