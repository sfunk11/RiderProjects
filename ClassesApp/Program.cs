namespace ClassesApp;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("audi", "a7",true);
        Car bmw = new Car("bmw", "z3", false);
        Console.WriteLine(Car.NumberOfCars + " cars produced.");

        Customer earl = new Customer("Earl");
        Customer bob = new Customer("Bob","3450 Main Street", "34344343");
        
        audi.Drive();
        bmw.Drive();
        
        earl.SetDetails("Earl Dobbs", "10 Fake Street", "350-303-3043");
        Console.WriteLine($"My customer is {earl.Name} and he lives at {earl.Address}.");
        bob.GetDetails();
        
        Console.WriteLine(AddNum(a: 25, 15));
        
        Rectangle r = new Rectangle();
        r.Width = 5.0;
        r.Height = 5.0;
        Console.WriteLine($"The area of the ractangle is {r.Area}.");

        Customer.DoSomeCustomerStuff();

    }

    static int AddNum(int a, int b)
    {
        return a + b;
    }
    
 


}