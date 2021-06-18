using System;
using System.Collections.Generic;
using System.Text;
using BikeStoreDomain.Core.Entities;
using BikeStoreServices.Entities;
using BikeStoreServices.InterFace;

namespace BikeStoreServices.Entities
{
    public class MainMenu:IShopCart
    {
        public DB _orderProduct = new DB();


        public void ListAllProduct()
        {
            List<Product> ItemList = _orderProduct.ListOfOrders();
            foreach (Product items in ItemList)
            {
                Console.WriteLine($"Name,Price and Size of the Product:{items.NameProduct},Price:{items.Price},Ram:{items.RamBike}");
            }
            
        }


        public void CreateOrder()
        {
            Product products = new Product();
            

            Console.WriteLine("Enter Product Name: ");
            products.NameProduct = Console.ReadLine();

            if ((products.NameProduct != "CubeAim") && (products.NameProduct != "Rog")&& (products.NameProduct != "Rocks"))
            {
                
                Console.WriteLine("Try again");
                CreateOrder();
            }
            

            Console.WriteLine("Order Summary");
            
            Console.WriteLine($"The product is :{products.NameProduct}");
            Console.WriteLine("Press Y to buy the product,or N to exit");
            string userInput2 = Console.ReadLine();
            switch (userInput2)
            {
                case "Y":
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("You bought a great bike");
                    Console.WriteLine($"{products.NameProduct}-Great german design dating from 1998");
                    Console.WriteLine("Tip: You should try the Vodno trail");
                    Console.WriteLine("=============================================================");
                    Console.WriteLine("=============================================================");
                    break;
                case "N":
                    Console.WriteLine("Hope you changed your mind next time");
                    CreateOrder();
                    break;
                default:
                    Console.WriteLine("Try again something went wrong");
                    break;
            }
            _orderProduct.AddOrder(products);


        }


        public void RemoveOrder()
        {
            Console.WriteLine("What order would you like to remove? ");
            List<Product> itemList = new List<Product>();

            foreach (Product item in itemList)
            {
                Console.WriteLine($"{item.ItemList}-{item.ItemList}");
            }
            Console.WriteLine("Product Removed");
            

        }
        public void Seed()
        {
            Product CubeAim = new Product("CubeAim", 37000, 29);
            Product Rog = new Product("Rog", 23000, 27);
            Product Rocks = new Product("Rocks", 18000, 25);

            _orderProduct.AddOrder(CubeAim);
            _orderProduct.AddOrder(Rog);
            _orderProduct.AddOrder(Rocks);
        }

        public void RunMenu()
        {

            bool runningMenu = true;
            while (runningMenu)
            {
                Console.WriteLine("<====================Welcome to my shop======================>");
                Console.WriteLine("1.See catalog with products");
                Console.WriteLine("2.Add an order");
                Console.WriteLine("3.Remove an Order");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ListAllProduct();
                        break;
                    case "2":
                        ListAllProduct();
                        CreateOrder();
                        break;
                    case "3":
                        RemoveOrder();
                        break;
                    case "4":
                        runningMenu = false;
                        break;
                    default:
                        Console.WriteLine("Try again .....");
                        break;
                }
            }
        }
        public void Run()
        {
            Seed();
            RunMenu();
        }
    }
    



}

