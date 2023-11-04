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
                string employ = input[1];
                if (!kvpCompany.ContainsKey(company))
                {
                    kvpCompany.Add(company, new List<string>());
                    kvpCompany[company].Add(employ);
                }
                else
                {
                    if (!kvpCompany[company].Contains(employ)) { kvpCompany[company].Add(employ); }

                }
            }
        }
    }
}
