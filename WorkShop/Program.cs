using System;
using System.Collections.Generic;
using WorkShop.Entities;
using System.Linq;

namespace WorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog dog01 = new Dog() { Name = "Belcho", Age = 2, Color = "black", Race = "Pit" };
            Dog dog02 = new Dog() { Name = "Tom", Age = 3, Color = "white", Race = "labrador" };
            Dog dog03 = new Dog() { Name = "Jericho", Age = 5, Color = "orange", Race = "Pit" };



            dog01.Print();
            dog02.Print();
            dog03.Print();

            Console.WriteLine("===============================================================");

            Bird bird01 = new Bird() { Name = "bird", Age = 3, Color = "white", IsWild = false };
            Bird bird02 = new Bird() { Name = "bird1", Age = 13, Color = "black", IsWild = true };
            Bird bird03 = new Bird() { Name = "bird2", Age = 5, Color = "orange", IsWild = false };

            bird01.Print();
            bird02.Print();
            bird03.Print();

            Console.WriteLine("===============================================================");

            Cat cat01 = new Cat() { Name = "Sara", Age = 3, Color = "white", isLazy = true };
            Cat cat02 = new Cat() { Name = "Sara1", Age = 3, Color = "white", isLazy = false };
            Cat cat03 = new Cat() { Name = "Sara2", Age = 3, Color = "white", isLazy = true };

            cat01.Print();
            cat02.Print();
            cat03.Print();

            

            Console.ReadLine();
        }
    }
}
