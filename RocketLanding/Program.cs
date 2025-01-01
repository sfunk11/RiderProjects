
string rocket = "  /\\ \n  | |\n /   \\";

for (int i = 0; i < 10; i++)
{
    Console.Clear();
    Console.WriteLine(rocket);
    rocket = "\n" + rocket;
    Thread.Sleep(600);
}

Console.WriteLine("The rocket has landed!");