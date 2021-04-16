using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMovieRent.Models
{
    public class Employee : Member
    {
        public double Salaray { get; set; }
        public int HoursPermonth { get; set; }

        public double Bonus { get; set; }

        public Employee() : base()
        {
            FirstName = "";
            LastName = "";
            UserName = "";
            Password = "";
        }

        public void SetSalary()
        {
            Salaray = 300;
        }

        public void SetBonus()
        {


            if (HoursPermonth > 160)
            {
                Bonus = (Salaray * 0.3) + Salaray;
                Console.WriteLine($"Employee has {Salaray} $$ wage per month, hours per month {HoursPermonth} and the wage + bonus is {Bonus} $$ for this month");
            }
            else
            {
                Salaray = Salaray;
                Console.WriteLine($"Employee has {Salaray} $$ wage per month, hours per month {HoursPermonth} and the wage  is {Salaray}");
            }

        }

        public void GetInfoEmployee()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");

            Console.WriteLine($"Employee Name: {UserName}");
            Console.WriteLine($"Employee password: {Password}");

        }

       

    }
}
