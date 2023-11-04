namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] inputs = Console.ReadLine().Split(" ");

                string comand = inputs[0];
                string owner = inputs[1];
                if (comand == "register")
                {
                    string licensePlateNumber = inputs[2];

                    if (!keyValuePairs.ContainsKey(owner))
                    {
                        keyValuePairs.Add(owner, licensePlateNumber);
                        Console.WriteLine($"{owner} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (comand == "unregister")
                {
                    if (!keyValuePairs.ContainsKey(owner))
                    {
                        Console.WriteLine($"ERROR: user {owner} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{owner} unregistered successfully");
                        keyValuePairs.Remove(owner);
                    }
                }
            }
            foreach (var user in keyValuePairs)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
