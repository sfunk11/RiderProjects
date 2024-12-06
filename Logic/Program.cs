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

int age = 13;

if (age >= 18)
{
    Console.WriteLine("Go Party!");
}
else
{
    Console.WriteLine("No club for you!");
}


Console.ReadKey();




