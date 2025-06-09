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
    gameInfo.AddNewRandomInt();
    for (int i = 0; i < gameInfo.NumSequence.Count; i++)
    {
        Console.WriteLine(gameInfo.NumSequence[i]);
        Thread.Sleep(1000);
        Console.Clear();
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

