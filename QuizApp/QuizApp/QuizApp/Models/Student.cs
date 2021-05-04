using QuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Models
{
    public class Student : User
    {

        public int Points { get; set; }

        public Student()
        {

        }

        public Student (string firstname, string lastname, string username, string password, Role role) : base(firstname, lastname, username, password, role)
        {
            Role = Role.Student;
        }

        public override void Welcome()
        {
            Console.WriteLine($"Welcome student: {FirstName} {LastName} you have {Points} on the exam");
        }
    }
}
