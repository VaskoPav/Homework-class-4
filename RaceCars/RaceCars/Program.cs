using System;

namespace RaceCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car[] cars = new Car[4];


            Car ford = new Car()
            {
                Model = "1.Corsa",
                Speed = 150,
            };
            Car seat = new Car()
            {
                Model = "2.Ibiza",
                Speed = 160,
            };
            Car audi = new Car()
            {
                Model = "3.A8",
                Speed = 260,
            };
            Car lada = new Car()
            {
                Model = "4.Niva",
                Speed = 190,
            };

            cars[0] = ford;
            cars[1] = seat;
            cars[2] = audi;
            cars[3] = lada;

            ///Drivers

            Driver[] drivers = new Driver[4];

            Driver firstDriver = new Driver()
            {
                Name = "1.Nicky Lauda",
                Skill = 10,
            };
            Driver secondDriver = new Driver()
            {
                Name = "2.James Hunt",
                Skill = 9,
            };
            Driver thirdDriver = new Driver()
            {
                Name = "3.Lewis Hamilton",
                Skill = 8,
            };
            Driver fourthDriver = new Driver()
            {
                Name = "4.Michael Shumacher",
                Skill = 11,
            };

            drivers[0] = firstDriver;
            drivers[1] = secondDriver;
            drivers[2] = thirdDriver;
            drivers[3] = fourthDriver;

            ////First driver and car

            Console.WriteLine("Select driver for the race:");
            for (int i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"Name :{drivers[i].Name}");
            }
            int numDriver1 = 0;
            bool numbersDrivers = int.TryParse(Console.ReadLine(), out numDriver1);



            Console.WriteLine("Select car for the race:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Model: {cars[i].Model}");
            }
            int numCar1 = 0;
            bool numbersCars1 = int.TryParse(Console.ReadLine(), out numCar1);




            /////Second driver and car

            Console.WriteLine("Select second driver for the race:");
            for (int j = 0; j < drivers.Length; j++)
            {
                Console.WriteLine($"Name: {drivers[j].Name}");
            }
            int numDriver2 = 0;
            bool numbersDrivers2 = int.TryParse(Console.ReadLine(), out numDriver2);




            Console.WriteLine("Select second car for the race:");
            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine($"Model: {cars[j].Model}");
            }
            int numCar2 = 0;
            bool numbersCars2 = int.TryParse(Console.ReadLine(), out numCar2);





            if (numbersDrivers && numbersCars1 && numbersDrivers2 && numbersCars2
             && (numDriver1 >= 0 || numDriver1 <= 3) && (numCar1 >= 0 || numCar1 <= 3) && (numDriver2 >= 0 || numDriver2 <= 3) && (numCar2 >= 0 || numCar2 <= 3))
            {
                Car firstCar = cars[numCar1];
                Car secondCar = cars[numCar2];

                firstCar.Driver = drivers[numDriver1];
                firstCar.Driver = drivers[numDriver2];

                Car.RaceCars(firstCar, secondCar);
            }
            else
            {
                Console.WriteLine("Error 404");
            }



            Console.ReadLine();
        }
    }
}
