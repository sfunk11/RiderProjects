namespace ClassesApp;

internal class Customer
{

    private static int NextId = 0;
    private readonly int _id;
    private string _password;

    //Read Only Property
    public int Id
    {
        get
        {
            return _id;
        }
    }
//Write only property
    public string Password
    {
        set
        {
            _password = value;
        }
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    //custom constructor

    public Customer(string name = "N/A", string address = "N/A", string contactNumber = "N/A")
    {
        _id = NextId++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    // unnecessary constructors
    
    // public Customer(string name)
    // {
    //     Name = name;
    // }

    // public Customer()
    // {
    //     Name = "default";
    //     Address = "default";
    //     ContactNumber = "default";
    // }

    public void SetDetails(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
        
    }

    public static void DoSomeCustomerStuff()
    {
        Console.WriteLine("I am doing customer stuff.");
    }

    public void GetDetails()
    {
        Console.WriteLine($"Customer ID is: {Id}. Name is: {Name}. Address is: {Address}. Contact number is: {ContactNumber}");
    }
    
}