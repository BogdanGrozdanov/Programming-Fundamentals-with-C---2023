namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> kvpCourses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" : ");
                if (comand[0] == "end") { break; }
                string course = comand[0];
                string name = comand[1];
                if (!kvpCourses.ContainsKey(course))
                {
                    kvpCourses.Add(course, new List<string>());
                    kvpCourses[course].Add(name);
                }
                else
                {
                    if (!kvpCourses[course].Contains(name))
                    { kvpCourses[course].Add(name); }
                }
            }
            foreach (var course in kvpCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
