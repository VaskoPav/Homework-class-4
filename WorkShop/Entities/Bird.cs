using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Entities
{
    public class Bird : Animal
    {
        public bool IsWild { get; set; }

        

        public override void Print()
        {
            if(IsWild == true)
            {
                Console.WriteLine($"Bird Name:{Name} flys south");
            }
            else if (IsWild == false)
            {
                Console.WriteLine($"Bird Name:{Name} is home bird, and poops everuwhere");
            }
        }
    }
}
