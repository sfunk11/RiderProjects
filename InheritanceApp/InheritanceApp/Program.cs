namespace InheritanceApp;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.MakeSound();

        Employee joe = new Employee("Joe", 25, "Representative", 12345);
    }

    //Base Class (Superclass or parent)
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
//use "virtual" keyword to make a method overridable
        public virtual void MakeSound()
        {
            Console.WriteLine("Making a sound...");
        }
    }

    //Child Class (derived class or subclass)
    class Dog : Animal
    {
        
        public override void MakeSound()
        {
            Console.WriteLine("Barking...");
        }
        
        
    }
//Subclasses can inherit from subclasses as well as base classes
    class Corgi : Dog
    {
        public void Herd()
        {
            Console.WriteLine("Herding...");
        }
    }

    //Multiple subclasses can inherit from single base class (Heirarchical inheritance)
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meowing...");
        }
    }
    
    //A class can only inherit from one class, but can be mimicked by inheriting from interfaces rather than classes

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Hello, {name} {age}");
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeId { get; private set; }
        // need base in signature for parent constructor parameters
        public Employee(string name, int age, string jobTitle, int employeeId) : base(name,age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            
        }
    }

    public class Manager : Employee
    {
        public Manager(string name, int age, string jobTitle, int employeeId) : base(name, age, jobTitle, employeeId)
        {
        }
    }
    
}