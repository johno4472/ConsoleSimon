// See https://aka.ms/new-console-template for more information
using ConsoleSimon;

Console.Clear();
Console.WriteLine("Let's play Simon!\nPress any key and enter to begin\n");
Console.ReadLine();
Console.Clear();

GameInfo gameInfo = new();

while (!gameInfo.GameOver)
{
    gameInfo.IntroduceLevel()

        //Adds a new number to the end of the list
        .AddNewNumber()

        //Prints all numbers in the sequence one at a time
        .PrintNumberSequence()

        //Tests plaMarks as game over when number incorrectly reported
        .TestNumberSequence();    
}

Console.WriteLine($"Wrong answer! Correct answer is {gameInfo.CorrectAnswer}. " +
                        $"Game over. You scored {gameInfo.Score}. Press any key to end.\n");
Console.ReadLine();
