using System.Threading.Tasks.Dataflow;

namespace ProgrammingFundamentalswithC__септември_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOftarget = Console.ReadLine().Split().Select(int.Parse).ToList();
            //0 1 2 3 4 5 6 7 8 9
            sequenceOftarget.RemoveRange(5,2);
            Console.WriteLine(string.Join(" ", sequenceOftarget));
        }
    }
}