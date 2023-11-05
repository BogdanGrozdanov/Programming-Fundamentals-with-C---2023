namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> kvpCompany = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                if (input[0] == "End") { break; }

                string company = input[0];
                string id = input[1];
                if (!kvpCompany.ContainsKey(company))
                {
                    kvpCompany.Add(company, new List<string>());
                    kvpCompany[company].Add(id);
                }
                else
                {
                    if (!kvpCompany[company].Contains(id))
                    { kvpCompany[company].Add(id); }
                }
            }

            foreach (var company in kvpCompany)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var ids in company.Value)
                {
                    Console.WriteLine($"-- {ids}");
                }
            }
        }
    }
}
