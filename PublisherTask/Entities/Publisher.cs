using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PublisherTask.Entities
{
    public delegate void MessageEventHandler(string message);
    public class Publisher
    {
        public event MessageEventHandler EventHandler;

        public void Publish(string message)
        {

            Thread.Sleep(3000);

            Inform(message);
        }

        protected virtual void Inform(string message)
        {

            EventHandler?.Invoke(message);
        }
    }
}
