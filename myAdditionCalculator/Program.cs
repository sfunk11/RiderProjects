//Simple program to add two user generated integers.

Console.WriteLine("Enter a number:");

int  firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("You entered " + firstNumber);
Console.WriteLine("Enter another number: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("You entered " + secondNumber);
int sum = firstNumber + secondNumber;
Console.WriteLine($"{firstNumber} plus {secondNumber} equals {sum}.");

Console.ReadKey();
