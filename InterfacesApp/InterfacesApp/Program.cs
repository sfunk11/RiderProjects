namespace InterfacesApp;

class Program
{
    static void Main(string[] args)
    {
       Dog dog = new Dog();
       dog.MakeNoise();
       dog.Eat("treats");
       
       Cat cat = new Cat();
       cat.MakeNoise();
       cat.Eat("meat");
    }
}

//interfaces start with "I"
public interface IAnimal
{
    void MakeNoise();
    void Eat(string food);
}

public class Dog : IAnimal
{
    public void Eat(string food)
    {
        Console.WriteLine($"Dog is eating {food}");
    }

    public void MakeNoise()
    {
        Console.WriteLine("Bark!");
    }
}

public class Cat : IAnimal
{
    public void Eat(string food)
    {
        Console.WriteLine($"Cat is eating {food}");
    }

    public void MakeNoise()
    {
        Console.WriteLine("Meow!");
    }
}