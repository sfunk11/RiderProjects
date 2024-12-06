//Simple program to add two user generated numbers..


using System.Globalization;

Console.WriteLine("Enter a number:");
double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("You entered " + firstNumber);
Console.WriteLine("Enter another number: ");
double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("You entered " + secondNumber);
double sum = firstNumber + secondNumber;
sum = Math.Round(sum, 2);
Console.WriteLine($"{firstNumber.ToString(CultureInfo.InvariantCulture)} plus {secondNumber} equals {sum}.");

Console.ReadKey();