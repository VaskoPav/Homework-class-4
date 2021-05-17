using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop.Entities
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        

        public abstract void Print();
    }
}
