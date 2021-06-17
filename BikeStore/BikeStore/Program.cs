using BikeStoreDomain.Core.Entities;
using BikeStoreServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BikeStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("Donald", "Trump", "user01", "pass01"));
            users.Add(new User("Boris", "Johnson", "user02", "pass02"));

            User user = null;

            while (true)
            {
                Console.WriteLine("<===================Welcome======================>");
                Console.WriteLine("<==============B I K E S H O P========================");
                Console.WriteLine("Log in to our products with discount of 5%");
                Console.WriteLine("Enter username:");
                string inputUserName = Console.ReadLine();
                user = users
                    .FirstOrDefault(x => x.UserName == inputUserName);

                if (user == null)
                {
                    Console.WriteLine("There isn't such username!");
                    continue;
                }

                Console.WriteLine("Enter password:");
                string inputPassword = Console.ReadLine();
                if (!user.ValidatePassword(inputPassword))
                {
                    Console.WriteLine("Wrong password, please try again!");
                    continue;
                }

                Console.WriteLine($"Successful login! Welcome Customer {user.GetFullName()}!");
                break;
            }

            MainMenu menuBar = new MainMenu();
            menuBar.Run();

            Console.ReadLine();
        }
    }
}
