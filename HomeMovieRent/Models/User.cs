using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMovieRent.Models
{
    public class User:Member
    {
        public int MemeberNumber { get; set; }
        public string Movie { get; set; }

        

        public User()
        {

        }

        public User(string firstName,string lastName, int age, string movie)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            

        }
        

       
    }
}
