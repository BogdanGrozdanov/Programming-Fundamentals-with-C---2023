namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            int counter = 0;

            string pass = Console.ReadLine();

            while (counter < 3)
            {
                counter++;
                if (password != pass)
                {
                    Console.WriteLine("Incorrect password. Try again."); pass = Console.ReadLine();
                }
                else if (password == pass)
                {
                    Console.WriteLine($"User {userName} logged in."); break;
                }
                if (counter == 3) { Console.WriteLine($"User {userName} blocked!"); }
            }
        }
    }
}