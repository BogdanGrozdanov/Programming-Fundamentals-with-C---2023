using System.Security.Cryptography;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string town = input[3];
                AddNotExistStudent(students, firstName, lastName, age, town);

                input = Console.ReadLine().Split().ToArray();
            }
            string filterByTown = Console.ReadLine();
            SortByTown(students, filterByTown);
        }

        public static void AddNotExistStudent(List<Student> students, string firstName, string lastName, int age, string town)
        {
            Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
            if (student == null)
            {
                students.Add(new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = town
                });
            }
            else
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = town;

            }
        }

        public static void SortByTown(List<Student> students, string filterByTown)
        {
            List<Student> sortByTown = students.Where(s => s.HomeTown == filterByTown).ToList();
            foreach (Student student in sortByTown)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
