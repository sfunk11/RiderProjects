namespace EventsApp;

//Using The Generic Delegate EventHandler<TEventArgs>


public delegate void TemperatureChangeHandler(string message);

public class TemperatureChangedEventArgs : EventArgs
{
    public int Temperature { get;}

    public TemperatureChangedEventArgs(int temperature)
    {
        Temperature = temperature;
    }
}
public class TemperatureMonitor
{

    public event EventHandler<TemperatureChangedEventArgs> OnTemperatureChanged;
    //public event TemperatureChangeHandler OnTemperatureChanged;
    
    private int _temperature;

    public int Temperature
    {
        get { return _temperature; }
        set
        {
            if (_temperature != value){
                
            _temperature = value;
            RaiseTemperatureChangedEvent(new TemperatureChangedEventArgs(_temperature));
            }}
    }

    protected virtual void RaiseTemperatureChangedEvent(TemperatureChangedEventArgs e)
    {
        OnTemperatureChanged?.Invoke(this,e);
    }
    
}

public class TemperatureAlert
{
    public void OnTemperatureChanged(object sender,TemperatureChangedEventArgs e)
    {
        Console.WriteLine("Alert: Temperature is {0} and Sender is {1}", e.Temperature, sender);
    }
}


public class Program
{
    
    
    static void Main(string[] args)
    {
        TemperatureMonitor monitor = new TemperatureMonitor();
        TemperatureAlert alert = new TemperatureAlert();
        monitor.OnTemperatureChanged += alert.OnTemperatureChanged;
        monitor.Temperature = 20;
        Console.WriteLine("Enter temperature: ");
        monitor.Temperature = int.Parse(Console.ReadLine());
        
        
        
    }
}