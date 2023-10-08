
using System.Diagnostics.Metrics;
using System.Globalization;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatorPassword(password);

        }

        static void ValidatorPasswordForLength(string password)
        {
            if (password.Length < 6 && password.Length > 10) { Console.WriteLine("Password must be between 6 and 10 characters"); }
        }
        static void ValidatorPasswordForContainLetterAndDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i])) { Console.WriteLine("Password must consist only of letters and digits"); }
            }
        }
        static void ValidatorPasswordForContainTwoDigit(string password)
        {
            int counter = 0;
            for(int i = 0;i < password.Length; i++) 
            {
                if (true)
                {

                }
            }
        }

        //for (int i = 0; i<password.Length; i++)
        //    {
        //        if (password[i] is not string && password[i]! is int)
        //        { Console.WriteLine("Password must consist only of letters and digits"); }
        //        if (password[i]! is int) { counter++; }
        //    }

        //    if (counter < 2) { Console.WriteLine("Password must have at least 2 digits"); }
    }
}
