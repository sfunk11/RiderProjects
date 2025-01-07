namespace StructsApp;

public class DateFun
{
    static void hMain(string[] args)
    {
        DateTime dt = new DateTime(1976, 11, 05);

        Console.WriteLine($"My birthday is {dt}.");
        
        //to get today
        Console.WriteLine(DateTime.Today);
        
        //To get current time and date as local time
        Console.WriteLine(DateTime.Now);
        
        DateTime tomorrow = GetTomorrow();
        Console.WriteLine($"Tomorrow will be {tomorrow}");
        
        Console.WriteLine(GetFirstDayOfYear(2207));
        
        Console.WriteLine(DateTime.DaysInMonth(1972, 2));

        DateTime now = DateTime.Now;
        
        Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

        Console.WriteLine("Write your birth date in this format: yyyy-mm-dd");
        string input = Console.ReadLine();
        if (DateTime.TryParse(input, out DateTime result))
        {
            Console.WriteLine(result);
            TimeSpan daysPassed = now.Subtract(result);
            Console.WriteLine("You are {0} days old", daysPassed.Days);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }

    static DateTime GetTomorrow()
    {
        return DateTime.Today.AddDays(1);
    }

    static DateTime GetFirstDayOfYear(int year)
    {
        return new DateTime(year, 1, 1);
    }
}