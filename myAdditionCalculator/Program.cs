//Simple program to add two user generated numbers..


Console.WriteLine("Enter a number:");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("You entered " + firstNumber);
Console.WriteLine("Enter another number: ");
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine("You entered " + secondNumber);
double sum = firstNumber + secondNumber;
Console.WriteLine($"{firstNumber} plus {secondNumber} equals {sum}.");

Console.ReadKey();
