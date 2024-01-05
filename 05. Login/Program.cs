using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int countOfTrying = 1;
            do
            {
                string enterPassword = Console.ReadLine();
                char[] stringArray = enterPassword.ToCharArray();
                Array.Reverse(stringArray);
                string password = new string(stringArray);

                if (password == username)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                countOfTrying++;
            }
            while (countOfTrying < 4);
            
            
            Console.WriteLine($"User {username} blocked!");
        }
    }
}
