using System;
using System.Text.RegularExpressions;

namespace CsLab2
{
    internal class Assiment5
    {
        public void Password()
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");
            }
        }

        static bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Z]") &&
                   Regex.IsMatch(password, @"[a-z]") &&
                   Regex.IsMatch(password, @"\d");
        }
    }
}
