using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle.Entities.Models
{
    public class Bicycle:WheeledVehicle
    {
        public int numberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }
        
        public Bicycle()
        {
            IsElectric = false;
        }

        public void Ride()
        {
            if (!IsElectric)
            {
                Console.WriteLine("You can ride to Vodno");
            }
            else
            {
                Console.WriteLine("Buy new bike");
            }
        }
    }
}
