namespace DependencyInjectionApp;

public class Hammer
{
    public void Use()
    {
        Console.WriteLine("Hammering nails");
    }
}
//Interface injection is a more complex version of setter injection
public class Builder : IToolUser
{
   private Hammer _hammer;
   private Saw _saw;
  //Setter injection 
   // public Hammer Hammer { get; set; }
   // public Saw Saw { get; set; }
   public void SetHammer(Hammer hammer)
   {
       _hammer = hammer;
   }

   public void SetSaw(Saw saw)
   {
      _saw = saw;
   }
  
//Constructor injection
    // public Builder(Hammer hammer, Saw saw)
    // {
    //     _hammer = hammer;
    //     _saw = saw;
    // }

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
//Interface injection
public interface IToolUser
{
    void SetHammer(Hammer hammer);
    void SetSaw(Saw saw);
}

public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

//Multiple Interface Inheritance example
public class MultiFunctionPrinter : IPrintable, IScannable
{
    public void Scan()
    {
        Console.WriteLine("Scanning...");
    }

    public void Print()
    {
        Console.WriteLine("Printing...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hammer myHammer = new Hammer();
        Saw mySaw = new Saw();
        Builder myBuilder = new Builder();
        // myBuilder.Hammer = myHammer;
        // myBuilder.Saw = mySaw;
        myBuilder.SetHammer(myHammer);
        myBuilder.SetSaw(mySaw);
        myBuilder.Build();
        
        MultiFunctionPrinter myMultiFunctionPrinter = new MultiFunctionPrinter();
        myMultiFunctionPrinter.Print();
        myMultiFunctionPrinter.Scan();
    }
}