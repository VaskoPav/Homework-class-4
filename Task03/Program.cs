using System;
using System.Collections.Generic;
using Task01.Entiteis;
using Task03.Entities;

namespace Task03
{
    class Program
    {
        
        static void Main(string[] args)
        {
           

            List<string> strings = new List<string>() { "My", "Generics", "Method" };
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };
            List<bool> booleans = new List<bool>() { true, true, false, true, false };

            Console.WriteLine("========================================================");

            GenericsMethods.SeeItems(strings);
            GenericsMethods.SeeThis(strings);

            Console.WriteLine("========================================================");

            GenericsMethods.SeeItems(integers);
            GenericsMethods.SeeThis(integers);

            Console.WriteLine("========================================================");

            GenericsMethods.SeeItems(booleans);
            GenericsMethods.SeeThis(booleans);

            Console.WriteLine("========================================================");

           



            Console.ReadLine();
        }
    }
}
