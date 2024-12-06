//Simple program to add two user generated integers.

Console.WriteLine("Enter a number:");

string firstNumber = Console.ReadLine();

Console.WriteLine("You entered " + firstNumber);
Console.WriteLine("Enter another number: ");
string secondNumber = Console.ReadLine();
Console.WriteLine("You entered " + secondNumber);

int firstNumberAsInt = int.Parse(firstNumber);
int secondNumberAsInt = int.Parse(secondNumber);
int result = firstNumberAsInt + secondNumberAsInt;
Console.WriteLine($"{firstNumber} plus {secondNumber} equals {result}.");

Console.ReadKey();
