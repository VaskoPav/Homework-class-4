using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle.Entities.Models
{
     public class Vehicle
    {
        public int Id { get; set; }
        public string Manufactor { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Manufactotr: {Manufactor} Model: {Model} ");
        }
    }
}
