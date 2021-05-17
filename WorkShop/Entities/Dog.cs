using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Entities
{
    public class Dog : Animal
    {
        public string Race { get; set; }

      

        public override void Print()
        {
            Console.WriteLine($"Dog {Name} Color {Color} with age {Age} and race:{Race} Bark Bark Bark");
        }
    }
}
