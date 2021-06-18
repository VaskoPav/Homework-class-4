using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreServices.InterFace
{
    public interface IShopCart
    {
        void ListAllProduct();
        void CreateOrder();
        void RemoveOrder();
    }
}
