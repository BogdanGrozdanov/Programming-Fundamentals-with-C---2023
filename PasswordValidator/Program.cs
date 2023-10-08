using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string errorMessage = "";

            if (!ValidatorPasswordForLength(password, ref errorMessage))
                Console.WriteLine(errorMessage);

            if (!ValidatorPasswordForContainLetterAndDigit(password, ref errorMessage))
                Console.WriteLine(errorMessage);

            if (!ValidatorPasswordForContainTwoDigit(password, ref errorMessage))
                Console.WriteLine(errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
                Console.WriteLine("Password is valid");
        }

        static bool ValidatorPasswordForLength(string password, ref string errorMessage)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                errorMessage = "Password must be between 6 and 10 characters";
                return false;
            }
            return true;
        }

        static bool ValidatorPasswordForContainLetterAndDigit(string password, ref string errorMessage)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "^[a-zA-Z0-9]+$"))
            {
                errorMessage = "Password must consist only of letters and digits";
                return false;
            }
            return true;
        }

        static bool ValidatorPasswordForContainTwoDigit(string password, ref string errorMessage)
        {
            int digitCount = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    digitCount++;
            }

            if (digitCount < 2)
            {
                errorMessage = "Password must have at least 2 digits";
                return false;
            }
            return true;
        }
    }
}
