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

        logDelegate = myLogger.LogToConsole;
        logDelegate += myLogger.LogToFile;
        
        //multicast delegates invoked in a try/catch
        foreach (LogHander logger in logDelegate.GetInvocationList())
        {
            try
            {
                logger("inside try ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        logDelegate -= myLogger.LogToConsole;
        logDelegate("after removing log to console");
        
        InvokeSafely(logDelegate, "Hello Delegate!");


    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void InvokeSafely(LogHander logDelegate, string message)
    {
        LogHander logDelegate2 = logDelegate;
        if (logDelegate2 != null)
        {
            logDelegate2(message);
        }
    }
}