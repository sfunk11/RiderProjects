namespace ClassesApp;

internal class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    //custom constructor

    public Customer(string name = "N/A", string address = "N/A", string contactNumber = "N/A")
    {
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
    
}