using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Interfaces
{
    public interface IProduct
    {
        string NameProduct { get; set; }
        int Price { get; set; }
        int RamBike { get; set; }
    }
}
