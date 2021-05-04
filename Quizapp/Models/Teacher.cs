using QuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Models
{
    public class Teacher:User
    {
        public Teacher()
        {

        }
        public Teacher(string firstname, string lastname, string username, string password, Role role) : base(firstname, lastname, username, password, role)
        {
            Role = Role.Teacher;
        }


        
    }
}
