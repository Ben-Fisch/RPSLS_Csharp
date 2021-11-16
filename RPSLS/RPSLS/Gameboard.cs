using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Gameboard
    {
        public void Run()
        {
            Welcome();
            GameType();
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to RPSLS!");
        }

        public void GameType()
        {
            Console.WriteLine("Please choose a game type: Single Player (1) or Multiplayer(2)");
           int gameType = Convert.ToInt32( Console.ReadLine());
           
            
        }
    }
}
