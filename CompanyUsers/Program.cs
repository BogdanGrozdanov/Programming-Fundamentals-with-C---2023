namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> kvpCompany = new Dictionary<string, Company>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                if (input[0] == "End") { break; }

                string company = input[0];
                string id = input[1];

                if (!kvpCompany.ContainsKey(company))
                {
                    Company ids = new Company(company);
                    kvpCompany.Add(company, ids);
                }
                kvpCompany[company].AddIds(id);
            }
            foreach (KeyValuePair<string, Company> pair in kvpCompany)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
    public class Company
    {
        public Company(string name)
        {
            Name = name;
            Ids = new List<string>();
        }
        public string Name { get; set; }
        public List<string> Ids { get; set; }

        public void AddIds(string id)
        {
            if (!Ids.Contains(id)) { Ids.Add(id); }
        }
        public override string ToString()
        {
            string result = $"{Name}\n";

            for (int i = 0; i < Ids.Count; i++)
            {
                result += $"-- {Ids[i]}\n";
            }

            return result.Trim();
        }

    }

}
