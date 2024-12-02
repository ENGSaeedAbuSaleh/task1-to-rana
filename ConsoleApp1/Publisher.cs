using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Publisher
    {
        // Declare the event using the delegate
        public event NotificationHandler OnNotify;

        // Method to trigger the event
        public void NotifySubscribers(string message)
        {
            if (OnNotify != null)
            {
                OnNotify(message);
            }
        }
    }

}
