using System.Collections.Concurrent;

namespace DelegatesAndEvents;

public delegate void LogHander(string message);

public class Logger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine(message);
    }

    public void LogToFile(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    
    //1, Declaration ( you can declare a delegate outside of any class if needed for access)
    public delegate void Notify(string message);
    
    
    static void Main(string[] args)
    {
        //2. Instantiation:
        Notify notifyDelegate = ShowMessage;
        
        //3. invokation
        notifyDelegate("Hello Delegate!");

        Logger myLogger = new Logger();
        LogHander logDelegate = myLogger.LogToConsole;
        logDelegate("Log to Console");
        
        logDelegate = myLogger.LogToFile;
        logDelegate("Log to File");
        

    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}