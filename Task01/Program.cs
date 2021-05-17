using System;
using System.Collections.Generic;
using Task01.Entiteis;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string text = "My first string";
            string first = text.FirstLetter(1);
            Console.WriteLine(first);

            Console.WriteLine("===========================");

            string mystring = "34234234d124";
            string res = mystring.GetLast(4);
            Console.WriteLine(res);

            Console.WriteLine("===========================");

            int i = 10;

            bool result = i.IsGreaterThan(100);
            Console.WriteLine(result);

            Console.WriteLine("===========================");

            List<int> integers = new List<int>() { 1, 2, 3, 4, 5 };

            integers.GoThrough();








            Console.ReadLine();
        }
    }
}
