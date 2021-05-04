using QuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Models
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        

        public User()
        {

        }

        public User(string firstname,string lastname,string username,string password, Role role)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            Password = password;
            Role = role;
        }
       
    }

}
