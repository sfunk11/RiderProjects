namespace EventsApp;

public delegate void Notify(string message);

public class EventPublisher
{
    public event Notify OnNotify;

    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message);
    }
}

public class EventSubscriber
{
    public void OnEventRaised(string message)
    {
        Console.WriteLine($"EventRaised: {message}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber eventSubscriber = new EventSubscriber();
        publisher.OnNotify += eventSubscriber.OnEventRaised;
        publisher.RaiseEvent("Hello World!");
    }
}