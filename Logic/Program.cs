// See https://aka.ms/new-console-template for more information

using System.Collections.Concurrent;



bool isRainy = true;
bool hasUmbrella = true;

//LOGICIAL OPERATORS ARE || && !

//VARIANTS OF OR:
//TRUE & TRUE -> TRUE
//TRUE & FALSE -> TRUE
//FALSE & TRUE -> TRUE
//FALSE & FALSE -> FALSE

//AND IS ONLY TRUE WHEN BOTH ARGS ARE TRUE

if (isRainy || hasUmbrella){
    
    
    Console.WriteLine("I'm not gettting wet");
}

if (isRainy && !hasUmbrella)
{
    Console.WriteLine("I'm gettting wet");
}
Console.WriteLine("A OK");

//Relational logic
Console.WriteLine("What is your age?");
int age = int.Parse(Console.ReadLine());
bool isWithParents = true;

if (age >= 18)
{
    Console.WriteLine("Go Party!");
}else if (age >= 13)
    {
        Console.WriteLine("Are you with your parent? Y or N");
        string isWithParentString = Console.ReadLine();
        if (isWithParentString == "Y")
        {
            Console.WriteLine("Go party!");
        }
        else
        {
            Console.WriteLine("No party for you!");
        }
    }
else if (age > 6)
{
    Console.WriteLine("Go to School");
}
else
{
    Console.WriteLine("Go party in Kindergsrten");
}


Console.ReadKey();




