using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SubscriberCollection : IEnumerable
    {
        private List<object> subscribers = new List<object>();

        public void AddSubscriber(object subscriber)
        {
            subscribers.Add(subscriber);
        }

        public IEnumerator GetEnumerator()
        {
            return new SubscriberEnumerator(subscribers);
        }
    }

    public class SubscriberEnumerator : IEnumerator
    {
        private List<object> _subscribers;
        private int position = -1;

        public SubscriberEnumerator(List<object> subscribers)
        {
            _subscribers = subscribers;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _subscribers.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return _subscribers[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}
