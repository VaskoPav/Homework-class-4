using System;
using System.Collections.Generic;
using System.Text;

namespace Task03.Entities
{
    public static class GenericsMethods
    {
        public static void SeeItems<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void SeeThis<T>(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members");
        }
        
    }
}
