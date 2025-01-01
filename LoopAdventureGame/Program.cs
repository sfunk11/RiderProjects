Console.WriteLine("Welcome to my adventure game!");
Console.WriteLine("Enter your character's name:");
string name = Console.ReadLine();
Console.WriteLine("Choose your character's class: Warrior, Wizard or Archer");
string className = Console.ReadLine();

Console.WriteLine($"You, {name} the {className}, find yourself at the edge of a dark forest on your quest to find the hidden treasure.");
Console.WriteLine(("Do you enter the forest or camp outside? Enter/Camp"));
string choice = Console.ReadLine().ToLower();

if (choice == "camp")
{
    Console.WriteLine("You camp outside the forest and then enter in the morning.");
}
else
{
    Console.WriteLine("You bravely enter the forest without camping first.");
}

bool gameContinue = true;
int luck = 0;
Random random = new Random();

while (gameContinue)
{
    Console.WriteLine("You approach a fork in the road. Do you go left or right?");
    choice = Console.ReadLine().ToLower();

    if (choice == "left")
    {
        luck = random.Next(1, 4);
        if (luck == 3)
        {
            Console.WriteLine("Congratulations! You found the hidden treasure chest and leave the forest.");
            gameContinue = false;
        }
        else
        {
            Console.WriteLine("You take the left fork and walk for a bit.");
        }
    }
    else
    {
        luck = random.Next(1, 10);
        if (luck < 6)
        {
            Console.WriteLine("You have encountered a wild beast!");
            Console.WriteLine("Do you fight or flee? (fight/flee)");
            choice = Console.ReadLine().ToLower();
            if (choice == "fight")
            {
                luck = random.Next(1, 10);
                if (luck > 6)
                {
                    if (luck == 10)
                    {
                        Console.WriteLine("You have defeated the beast and it dropped a treasure.");
                    }
                    else
                    {
                        Console.WriteLine("You have defeated the beast and can continue your quest.");
                    }
                }
                else
                {
                    Console.WriteLine("The beast gores you with its massive tusks and you bleed to death.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("You flee from the dark forest, your quest forgotten for today.");
                gameContinue = false;
                break;
            }
        }
        else
        {
            Console.WriteLine("You do not encounter anything on the right forkSam and continue on.");
        }
        Console.WriteLine("Do you continue on or leave the forest? (continue/leave)");
        choice = Console.ReadLine().ToLower();
        if (choice == "continue")
        {
            Console.WriteLine("You continue down the path for a bit.");
        }
        else
        {
            Console.WriteLine("You decide that you don't want the hidden treasure and leave the forest.");
            gameContinue = false;
        }
    }
}
Console.WriteLine("Thank you for playing!");