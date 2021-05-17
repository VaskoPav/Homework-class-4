using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PublisherTask.Entities
{
    public class Sub1
    {
        public void SubscribeOneProcessing(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"SubOne received this message: {message}");
        }
    }
}
