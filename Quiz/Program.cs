

string question1 = "What is the capital of Germany?";
string answer1 = "Berlin";

string question2 = "What is 2 + 2?";
string answer2 = "4";
string question3= "what color do you get by mixing yellow and blue?";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1 == answer1)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong!");
}

Console.WriteLine($"Quiz completed. Score is {score}/3");

if (score == 3)
{
    Console.WriteLine("Great job! You got them all right!");
}
else if (score < 3)
{
    Console.WriteLine("Not bad, but you could do better");
}
else
{
    Console.WriteLine("Keep learning and try again!");
}