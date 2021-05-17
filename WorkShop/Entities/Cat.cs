using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Entities
{
    public class Cat : Animal
    {
        public bool isLazy { get; set; }


       

        public override void Print()
        {
            Console.WriteLine($"Cat: Name:{Name} is lazy: {isLazy} and Meow Meow all day");
        }
    }
}
