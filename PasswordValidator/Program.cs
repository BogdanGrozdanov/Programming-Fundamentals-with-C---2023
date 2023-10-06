
using System.Diagnostics.Metrics;
using System.Globalization;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] password = Console.ReadLine().Split("");
            ValidatorPassword(password);

        }

        static void ValidatorPassword(string[] password)
        {
            int counter = 0;
            if (password.Length < 6 || password.Length > 10) { Console.WriteLine("Password must be between 6 and 10 characters"); }
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i]! is string && password[i]! is int)
                { Console.WriteLine("Password must consist only of letters and digits"); }
                if (password[i] is int) { counter++; }
            }
            if (counter < 2) { Console.WriteLine("Password must have at least 2 digits"); }
        }
    }
}
