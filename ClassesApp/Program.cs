namespace ClassesApp;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("audi", "a7",true);
        Car bmw = new Car("bmw", "z3", false);

        Customer earl = new Customer("Earl");
        Customer bob = new Customer("Bob","3450 Main Street", "34344343");
        
        audi.Drive();
        bmw.Drive();
        
    }
}