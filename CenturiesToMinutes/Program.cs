namespace CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centuries = int.Parse(Console.ReadLine());
            string result = $"{centuries} centuries = {centuries * 100} years = {centuries * 36524.22} days = {centuries * 876576} hours = {52594560 * centuries} minutes";
            Console.WriteLine(result);
        }
    }
}
