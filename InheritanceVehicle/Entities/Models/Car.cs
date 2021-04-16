using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVehicle.Entities.Models
{
    public class Car:WheeledVehicle
    {
        public string EnqineType { get; set; }
        public int FuelConsumption { get; set; }

        public int NumbersOfDoor { get; set; }
        public int MaxSpeed { get; set; }

        public Car()
        {
                
        }

        public Car( string enqineType, int fuelConsumption,int numbersDoors,int maxSpeed,string manufactor,string model): base(4,"car")
        {
            Manufactor = manufactor;
            Model = model;
            EnqineType = enqineType;
            FuelConsumption = fuelConsumption;
            NumbersOfDoor = numbersDoors;
            MaxSpeed = maxSpeed;
            

        }


        public void Drive()
        {
            if(FuelConsumption >= 5)
            {
                Console.WriteLine("Your are good");
                
            }
            else
            {
                Console.WriteLine("Put gass ");
            }
            
        }
        public void DriveInfo()
        {
            Console.WriteLine($"This model is with {FuelConsumption} liters per 100km/h, this enqine type: {EnqineType}, has {NumbersOfDoor} doors and top speed {MaxSpeed}");
        }

    }
}
