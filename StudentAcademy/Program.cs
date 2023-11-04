using System.Xml.Linq;

namespace StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                    students[student].Add(grade);
                }
                else
                {
                    students[student].Add(grade);
                }
            }
            foreach (var student in students)
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
                }
            }
        }
    }
}

