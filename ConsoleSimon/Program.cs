// See https://aka.ms/new-console-template for more information
using ConsoleSimon;
Console.Clear();
Console.WriteLine("Let's play Simon!\nPress any key and enter to begin\n");
Console.ReadLine();
Console.Clear();
bool lost = false;
GameInfo gameInfo = new GameInfo();
while (!lost)
{
    if (gameInfo.NumSequence.Count > 0)
    {
        Console.WriteLine("Next level!\n");
        Thread.Sleep(500);
        Console.Clear();
    }
    gameInfo.AddNewRandomInt();
    for (int i = 0; i < gameInfo.NumSequence.Count; i++)
    {
        Console.Write(gameInfo.NumSequence[i]);
        Thread.Sleep(1000);
        Console.Clear();
        Thread.Sleep(500);
    }
    for (int i = 0; i < gameInfo.NumSequence.Count; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        string userResponse = Console.ReadLine();
        int intResponse = Convert.ToInt32(userResponse);
        if (intResponse != gameInfo.NumSequence[i])
        {
            Console.WriteLine($"Wrong answer! Correct answer is {gameInfo.NumSequence[i]}. " +
                $"Game over. You scored {gameInfo.NumSequence.Count - 1}. Press any key to end.\n");
            Console.ReadLine();
            lost = true;
            break;
        }
    }
}

