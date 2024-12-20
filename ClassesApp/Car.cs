
namespace ClassesApp;

internal class Car
{
    //member variable
    private string _model = "";
    private string _make = "";
    private bool _isLuxury = false;
    
    //Constructor
    
    public Car()
    {
        Console.WriteLine("An Object of Car has been created");
    }

    public Car( string make, string model, bool luxury)
    {
        Model = model;
        Make = make;
        _isLuxury = luxury;
        Console.WriteLine($"{Make} {Model} has been created");
    }

    //Properties
    public string Model
    {
        get
        {
            if (IsLuxury)
            {
                return _model + " Luxury Edition";
            } 
            return _model;
        }
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Make
    {
        get => _make;
        set => _make = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool IsLuxury
    {
        get => _isLuxury;
        
    }

    public void Drive()
    {
        Console.WriteLine($"{Make} {Model} is driving");
    }
    
}