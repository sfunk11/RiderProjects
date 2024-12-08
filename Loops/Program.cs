// // basic for loop
//
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine("i is " + i);
// }
//
// // decrementing for loop with 1 sec delay
//
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine("i is " + i);
//     Thread.Sleep(1000);
// }

// basic while loop
//
// int counter = 0;
// while (counter < 10)
// {
//     Console.WriteLine("counter is " + counter);
//     counter++;
// }
//

// Console.WriteLine("Do you want to go for a run? Type Go or stay");
// string userChoice = Console.ReadLine().ToLower();
//
//
//
// while (userChoice == "go")
// {
//     Console.WriteLine("Go for a mile.");
//     Console.WriteLine("Do you want to keep going? Type go or stay");
//     userChoice = Console.ReadLine().ToLower();
// }
// Console.WriteLine("All done!");
//

// // guess a number app
// Random random = new Random();
// int number = random.Next(1, 101);
// int userGuess = 0;
// int counter = 0;
// while (userGuess != number)
// {
//     Console.WriteLine("Guess a number between 1 and 100:");
//     userGuess = int.Parse(Console.ReadLine());
//
//     if (userGuess > number)
//     {
//         Console.WriteLine("Too high, try again.");
//     }
//     else
//     {
//         Console.WriteLine("Too low, try again.");
//     }
//
//     counter++;
// }
//
// Console.WriteLine($"You guessed the number correctly! It took you {counter} tries.");

/*
// Average calculator

int currentScore;
double sum = 0;
int counter = 0;

do
{
    Console.WriteLine(("Enter a number.  To finish and calculate the average of entered numbers, enter -1."));
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != -1)
    {
    sum += currentScore;
    counter++;
    }
} while (currentScore != -1) ;

if (counter != 0)
{
    double average = sum / counter;
    average = Math.Round(average, 2);
    Console.WriteLine("The average is {0}.", average);
}
else
{
    Console.WriteLine("I can't calculate the average of nothing.");
}

*/
// For Each loops

string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

foreach (string day in weekdays)
{
    Console.WriteLine(day);

}

int[,] array2D = { { 1, 2 }, { 3, 4 } };
foreach ( int item in array2D)
{
    Console.WriteLine(item);

}



