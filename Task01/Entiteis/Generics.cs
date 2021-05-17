using System;
using System.Collections.Generic;
using System.Text;

namespace Task01.Entiteis
{
    public static class Generics
    {
        public static void GoThrough<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
