using BikeStoreDomain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreDomain.Core.Entities
{
    public class DB : IDB
    {
        public List<Product> _orders = new List<Product>();

        public void AddOrder(Product order)
        {
            _orders.Add(order);
        }

        public bool RemoveOrder(Product order)
        {
            int count = _orders.Count;
            _orders.Remove(order);
            if (count > _orders.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Product> ListOfOrders()
        {
            return _orders;
        }
    }
}
