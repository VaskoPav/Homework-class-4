using BikeStoreDomain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Interfaces
{
    public interface IDB
    {
        void AddOrder(Product order);
        bool RemoveOrder(Product order);
    }
}
