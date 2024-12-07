//Simple program to add two user generated numbers..


using System.Globalization;

Console.WriteLine("Enter a number:");
double firstNumber= 0.0;
string inputString =Console.ReadLine();
bool isNumber = double.TryParse(inputString,out firstNumber);

if (isNumber)
{
    Console.WriteLine($"You entered {firstNumber}");
    isNumber = false;
}
else
{
    Console.WriteLine("You did not enter a number.  Your number is 0");
}

Console.WriteLine("Enter another number: ");
double secondNumber = 0.0;
inputString=Console.ReadLine();
isNumber = double.TryParse(inputString, out secondNumber);

if (isNumber)
{
    Console.WriteLine($"You entered {firstNumber}");
    isNumber = false;
}
else
{
    Console.WriteLine("You did not enter a number.  Your number is 0");
}

double sum = firstNumber + secondNumber;
sum = Math.Round(sum, 2);
Console.WriteLine($"{firstNumber} plus {secondNumber} equals {sum}.");

Console.ReadKey();