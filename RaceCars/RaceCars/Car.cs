using System;
using System.Collections.Generic;
using System.Text;

namespace RaceCars
{
    class Car
    {
        public Car()
        {

        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        //CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.

        public int CalculateSpeed()
        {
            return this.Driver.Skill + this.Speed;
        }
        static public void RaceCars(Car firstCar, Car secondCar)
        {

            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
            {
                Console.WriteLine($"{firstCar.Driver.Name} driving {firstCar.Model} wins");
            }
            else if (firstCar.CalculateSpeed() < secondCar.CalculateSpeed())
            {
                Console.WriteLine($"{secondCar.Driver.Name} driving {secondCar.Model} wins");
            }
            else
            {
                Console.WriteLine("They are equal");
            }

        }
    }
}
