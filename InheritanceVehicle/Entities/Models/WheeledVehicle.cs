using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle.Entities.Models
{
    public class WheeledVehicle:Vehicle
    {
        public int NumberOfWheels { get; set; }

        public string Type { get; set; }

        public WheeledVehicle()
        {

        }
        public WheeledVehicle(int numbersOfWheels,string type)
        {

        }

        public void Reparir()
        {
            
            Console.WriteLine($"Repair Method");
        }
    }
}
 