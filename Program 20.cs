using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== User Registration ===");

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password (alphanumeric): ");
        string password = Console.ReadLine();

        Console.Write("Re-enter Password: ");
        string retype = Console.ReadLine();

        Console.Write("Enter Date of Birth (dd-mm-yyyy): ");
        string dob = Console.ReadLine();

        Console.Write("Enter a password hint: ");
        string hint = Console.ReadLine();

        Console.Write("Remember me on this computer? (yes/no): ");
        string remember = Console.ReadLine();

        // Validation
        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(retype) ||
            string.IsNullOrWhiteSpace(dob) ||
            string.IsNullOrWhiteSpace(hint))
        {
            Console.WriteLine("❌ Error: All fields are required.");
            return;
        }

        if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
        {
            Console.WriteLine("❌ Error: Password must be alphanumeric.");
            return;
        }

        if (password != retype)
        {
            Console.WriteLine("❌ Error: Passwords do not match.");
            return;
        }

        DateTime parsedDob;
        if (!DateTime.TryParse(dob, out parsedDob))
        {
            Console.WriteLine("❌ Error: Invalid date of birth format.");
            return;
        }

        Console.WriteLine("\n✅ Registration Successful!");
        Console.WriteLine($"Welcome, {username}!");

        if (remember.ToLower() == "yes")
        {
            Console.WriteLine("🔒 You will be remembered on this device.");
        }
    }
}
