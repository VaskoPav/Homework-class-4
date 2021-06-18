using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }

        public User(string firstName, string lastName, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Password = password;
        }
        public bool ValidatePassword(string pass)
        {
            return this.Password == pass;
        }
        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
