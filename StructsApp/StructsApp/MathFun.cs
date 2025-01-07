namespace StructsApp;

public class MathFun
{
    static void Main(string[] args)
    {
        Console.WriteLine(Math.Ceiling(34.549));
        Console.WriteLine(Math.Floor(34.549));

        int num1 = 13;
        int num2 = 2;

        Console.WriteLine("lower value is " + Math.Min(num1, num2));
        Console.WriteLine("upper value is " + Math.Max(num1, num2));

        Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3, 5));
        Console.WriteLine("Pi is {0}", Math.PI);
        Console.WriteLine("The square root of 25 is {0}", Math.Sqrt(25));
        Console.WriteLine("Always positive is {0}", Math.Abs(-324));
        Console.WriteLine("cos of 1 is {0}", Math.Cos(1));
    }
}