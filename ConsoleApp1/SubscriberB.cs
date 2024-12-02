using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubscriberB
    {
        public void OnNotificationReceived(string message)
        {
            Console.WriteLine($"Subscriber B received: {message}");
        }
    }

}
