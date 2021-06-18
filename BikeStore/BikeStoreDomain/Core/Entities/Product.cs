using BikeStoreDomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Entities
{
    public class Product : BaseEntity, IProduct
    {
        public int ItemList { get; set; }
        
        public string NameProduct { get ; set ; }
        public int Price { get ; set; }
        public int RamBike { get ; set ; }


        public Product(string name,int price,int ram)
        {
           
            NameProduct = name;
            Price = price;
            RamBike = ram;
        }

        public Product()
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name of the product:{NameProduct} with price {Price} and bikesize {RamBike}");
        }
    }
}
