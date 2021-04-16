using System;
using InheritanceVehicle.Entities.Models;

namespace InheritanceVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Vehicle seat = new Vehicle()
            {
                Id = 2,
                Manufactor = "Wolvsvaken",
                Model = "Ibiza"

            };
            seat.PrintInfo();

            Console.WriteLine("==================");

            WheeledVehicle ford = new WheeledVehicle()
            {
                Id = 3,
                Manufactor = "General Motors",
                Model="S4",

            };
            ford.PrintInfo();
            ford.Reparir();

            Console.WriteLine("==================");

            Car fordKa = new Car()
            {
                Id = 4,
                Manufactor = "Audi",
                Model = "vs",
                FuelConsumption=4,
                EnqineType="V6",
                NumbersOfDoor=4,
                MaxSpeed=200
            };
            fordKa.Drive();
            fordKa.PrintInfo();
            fordKa.DriveInfo();

            Console.WriteLine("==================");

            ElectricCar teska = new ElectricCar()
            {
                Id = 5,
                Manufactor = "Tesla",
                Model = "S3",
                BateryCapacity=100,
                BateryPercentage=12
            };
            teska.PrintInfo();
            teska.Recharge();

            Console.WriteLine("==================");
            Bicycle cube = new Bicycle()
            {
                Id = 6,
                Manufactor = "Cube",
                Model = "R7",
                numberOfSpeedLevels = 27,
                IsElectric = false,
            };
            cube.PrintInfo();
            cube.Ride();




            Console.ReadLine();
        }
    }
}
