using PublisherTask.Entities;
using System;

namespace PublisherTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Publisher pub = new Publisher();
            Sub1 sub1 = new Sub1();
            Sub2 sub2 = new Sub2();

            pub.EventHandler += sub1.SubscribeOneProcessing;
            pub.EventHandler += sub2.SubscribeTwoProcessing;

            pub.Publish("Something is going on");

            Console.ReadLine();
        }
    }
}
