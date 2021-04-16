using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMovieRent.Models
{
    public class Member
    {
        
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public int PhoneNumber { get; set; }

            public DateTime DateOfRegistration { get; set; }

            public Member()
            {

            }


            public Member(string firstName, string lastName, int age, string userName, string password, int phonenumbers)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                UserName = userName;
                Password = password;
                PhoneNumber = phonenumbers;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Welcome new User!Your name is {FirstName} {LastName},and you are {Age} old  with user name {UserName} and password {Password} ,registered on {DateOfRegistration}");
            }
        
    }
}
