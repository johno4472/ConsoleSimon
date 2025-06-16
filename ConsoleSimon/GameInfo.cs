using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSimon
{
    public class GameInfo
    {
        public List<int> NumSequence { get; set; } = [];

        public bool GameOver = false;

        public int CorrectAnswer {  get; set; }

        public int Score { get; set; }

        public GameInfo AddNewNumber()
        {
            Random random = new();
            this.NumSequence.Add(random.Next(10));
            return this;
        }

        public GameInfo IntroduceLevel()
        {
            if (NumSequence.Count > 0)
            {
                Console.WriteLine("Next level!\n");
                Thread.Sleep(500);
                Console.Clear();
            }
            else { Console.WriteLine("First Level!"); }
            return this;
        }

        public GameInfo PrintNumberSequence()
        {
            for (int i = 0; i < NumSequence.Count; i++)
            {
                Console.Write(NumSequence[i]);
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(500);
            }
            return this;
        }

        public GameInfo TestNumberSequence()
        {
            for (int i = 0; i < NumSequence.Count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                string userResponse = Console.ReadLine() ?? "";
                try
                {
                    int intResponse = Convert.ToInt32(userResponse);

                    if (intResponse != NumSequence[i])
                    {
                        CorrectAnswer = NumSequence[i];
                        Score = NumSequence.Count - 1;
                        GameOver = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("You didn't even enter a valid number. try again");
                    i--;
                }
            }
            return this;
        }
    }
}
