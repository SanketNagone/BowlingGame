using BowlingGame;

const int rolls = 21;

startnew:
Console.WriteLine("Welcome!!! To Bowling Arena");

Console.WriteLine("Let's Start the game...Hit Enter to throw.");

Game game = new Game();
Random random = new Random();
int rollsCounter = 0;
int firstRoundPins = 0;
int pins;

while (rollsCounter < rolls) 
{
    bool isFirstThrowofFrame = false;

    ConsoleKeyInfo keyInfo = Console.ReadKey();
    while (keyInfo.Key != ConsoleKey.Enter)
        keyInfo = Console.ReadKey();
   

    if (rollsCounter % 2 == 0)
        isFirstThrowofFrame = true;

    if (isFirstThrowofFrame)
    {
        pins = random.Next(0, 10);
        firstRoundPins = pins;
    }
    else
    {
        int diff = 10 - firstRoundPins;
        pins = random.Next(0, diff);
    }


    Console.WriteLine($"Hit {pins}");
    game.Throw(pins);

    if (rollsCounter % 2 != 0)
        Console.WriteLine($"Score is {game.Score}");

    if (isFirstThrowofFrame && pins == 10)
    {
        rollsCounter += 2;
    }
    else
        rollsCounter++;

   
}



Console.WriteLine($"Final Score is {game.Score}");

Console.WriteLine("Hit Enter to start new Game.");

ConsoleKeyInfo enterKeyInfo = Console.ReadKey();
while (enterKeyInfo.Key != ConsoleKey.Enter)
    enterKeyInfo = Console.ReadKey();

Console.Clear();
goto startnew;