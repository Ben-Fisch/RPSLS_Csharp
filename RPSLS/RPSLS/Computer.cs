using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public Computer(string name, string choice)
        {
            this.name = name;
            this.choice = choice;
        }

        public Computer()
        {
            Random rand = new Random();
            list = new List<string> {"Rock", "Paper", "Scissors", "Lizard", "Spock" };
            
        }
    }
}
