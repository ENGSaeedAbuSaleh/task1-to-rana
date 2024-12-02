// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

public delegate void NotificationHandler(string message);

public partial class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        SubscriberA subscriberA = new SubscriberA();
        SubscriberB subscriberB = new SubscriberB();

        // Subscribe to the event
        publisher.OnNotify += subscriberA.OnNotificationReceived;
        publisher.OnNotify += subscriberB.OnNotificationReceived;

        // Create a collection and add subscribers
        SubscriberCollection subscriberCollection = new SubscriberCollection();
        subscriberCollection.AddSubscriber(subscriberA);
        subscriberCollection.AddSubscriber(subscriberB);

        // Notify subscribers
        publisher.NotifySubscribers("Event 1 Occurred");

        // Iterate through the collection of subscribers (demonstrating IEnumerable and IEnumerator)
        foreach (var subscriber in subscriberCollection)
        {
            Console.WriteLine($"Subscriber in collection: {subscriber.GetType().Name}");
        }
    }
}
