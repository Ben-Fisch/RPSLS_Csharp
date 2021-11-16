using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Gameboard
    {
        public string playerOne;
        public string playerTwo;

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
            Console.WriteLine("Please choose a game type: Single Player (1) or Multiplayer (2)");
           string game = Console.ReadLine();
            if(game == "1")
            {
                playerOne = new Player("Bill");

            }
           
            
        }
    }
}
