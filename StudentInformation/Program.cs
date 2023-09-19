namespace StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //student name
            string name = Console.ReadLine();
            //· age
            double age = double.Parse(Console.ReadLine());
            //· average grade
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}