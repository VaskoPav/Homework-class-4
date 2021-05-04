using QuizApp.Enums;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    class Program
    {
     
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new Student("Vasko", "Pavlovski", "vase", "vase123", Role.Student));
            users.Add(new Student("Jack", "Sparoow", "pirate", "jack", Role.Student));
            

            users.Add(new Teacher("Cristiano", "Ronaldo", "cr7", "juve", Role.Teacher));



            Console.WriteLine("-------------------Quiz---------------");
            User user = null;
            while (true)
            {
                Console.WriteLine("Enter your username");
                string inputUserName = Console.ReadLine();
                user = users
                        .FirstOrDefault(x => x.UserName == inputUserName);
                if(user== null)
                {
                    Console.WriteLine("Try again");
                }

                Console.WriteLine("Enter a password");
                string inputPassword = Console.ReadLine();
                user = users
                        .FirstOrDefault(x => x.Password == inputPassword);
                if(user== null)
                {
                    Console.WriteLine("Try again");
                    continue;
                }
                Console.WriteLine($"Welcome Student {user.FirstName}");

                Console.WriteLine("Questions Exam");

                Questions.QuestionsAnswer();
                
                
                    


            }


            
        }
    }
}
