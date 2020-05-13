using System;
using System.Collections.Generic;
using userConsole.models;

namespace userConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            User joshSchoenecker = new User("schoeneckerj", "password");

            Dictionary<string, User> users = new Dictionary<string, User>();

            users.Add(joshSchoenecker.Username.ToLower(), joshSchoenecker);

            System.Console.WriteLine("Welcom to login.\nPlease enter a \"username\" and password combination to login");
            System.Console.Write("Username: ");
            string nameInput = Console.ReadLine();
            System.Console.WriteLine("\nPassword: ");
            string passwordInput = Console.ReadLine();
            if (users.ContainsKey(nameInput.ToLower()) && users[nameInput.ToLower()].Password == passwordInput)
            {
                System.Console.WriteLine($"You logged in as {users[nameInput.ToLower()].Username}");
            }
            else
            {
                System.Console.WriteLine("Username or Password is incorrect!");
            }
        }
    }
}
