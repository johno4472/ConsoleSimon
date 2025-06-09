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

        public void AddNewRandomInt()
        {
            Random random = new Random();
            this.NumSequence.Add(random.Next());
        }
    }
}
