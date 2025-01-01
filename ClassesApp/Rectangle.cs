namespace ClassesApp;

public class Rectangle
{
    public const int NumberOfCorners = 4;
    public readonly string Color;
    public double Width { get; set; }
    public double Height { get; set; }
    
    public double Area => Width * Height;

    public Rectangle(string color = "transparent", double width = 1, double height =1 )
    {
        Color = color;
        Width = width;
        Height = height;

    }
}