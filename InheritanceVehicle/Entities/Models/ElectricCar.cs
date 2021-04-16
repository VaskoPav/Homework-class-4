using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle.Entities.Models
{
    public class ElectricCar:Car
    {
        public int BateryCapacity { get; set; }
        public int BateryPercentage { get; set; }

        public void Recharge()
        {
            if (BateryPercentage >= 13)
            {
                Console.WriteLine("You have electrical power to drive");
            }
            else
            {
                Console.WriteLine("Put your car on a charger");
            }
        }
    }
}
