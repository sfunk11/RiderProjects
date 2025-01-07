namespace StructsApp;

//It is common practice to make structs immutable by using readonly and only providing get accessors for properties
public struct Point
{
    public double X { get; }
    public double Y { get; }

    // public int x;
    // public int y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // public Point(int x, int y)
    // {
    //     this.x = x;
    //     this.y = y;
    // }
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }

    public double Distance(Point p)
    {
        double dx = X - p.X;
        double dy = Y - p.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        p1.Display();

        Point p2 = new Point(20, 50);
        p2.Display();
        double distance = p1.Distance(p2);
        Console.WriteLine($"Distance between points: {distance:F2}");
        // Point p2;
        // p2.x = 10;
        // p2.y = 20;
        // p2.Display();
        //
        // Point p3 = p1;
        // p3.x = 50;
        // p3.Display();
        // p1.Display();

    }
}