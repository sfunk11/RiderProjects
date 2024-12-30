namespace ListsApp;

class Program
{
    static void Main(string[] args)
    {
        List<string> colors = new List<string>();
        colors.Add("red");
        colors.Add("green");
        colors.Add("blue");
        colors.Add("red");

        Console.WriteLine("Current colors in the list:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        
        // .Remove() removes first occurence only
        colors.Remove("red");
        Console.WriteLine("Current colors in the list:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        
        
    }
}