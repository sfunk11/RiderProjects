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
       
       IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
       PaymentService paymentService = new PaymentService(creditCardProcessor);
       paymentService.ProcessOrderPayment(100.00m);
       
       PaypalProcessor payPalProcessor = new PaypalProcessor();
       paymentService = new PaymentService(payPalProcessor);
       paymentService.ProcessOrderPayment(100.00m);

       ILogger fileLogger = new FileLogger();
       fileLogger.Log("Hello World!");
       
       ILogger dbLogger = new DatabaseLogger();
       Application app = new Application(dbLogger);
       
       app.DoWork();
       

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


public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit card processed {amount}");
        //Implement credit card payment logic
    }
}

public class PaypalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Paypal payment processed {amount}");
        //Implement PayPal payment logic
    }
}

public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}

public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            //example for creating / writing to a file on your computer
            //"@" is used to denote a string literal with no escape chars
            string directoryPath = @"~/Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath,message); 
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Doing work");
            //do all the work.
            _logger.Log("Work done");
        }

    }