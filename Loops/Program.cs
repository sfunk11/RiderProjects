// basic for loop

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("i is " + i);
}

// decrementing for loop with 1 sec delay

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine("i is " + i);
    Thread.Sleep(1000);
}

