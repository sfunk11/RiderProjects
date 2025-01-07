namespace DependencyInjectionApp;

public class Hammer
{
    public void Use()
    {
        Console.WriteLine("Hammering nails");
    }
}

public class Builder
{
    private Hammer _hammer;
    private Saw _saw;

    public Builder(Hammer hammer, Saw saw)
    {
        _hammer = hammer;
        _saw = saw;
    }

    public void Build()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House built");
    }
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing wood.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Hammer myHammer = new Hammer();
        Saw mySaw = new Saw();
        Builder myBuilder = new Builder(myHammer, mySaw);
        myBuilder.Build();
    }
}