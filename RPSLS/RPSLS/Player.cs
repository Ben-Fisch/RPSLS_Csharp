using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string name;
        public int score = 0;
        public List<string> gestures;
        public string choice;

        public Player()
        {
            gestures = new List<string>();
            GenerateGestures();
        }

        public void GenerateGestures()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

    }
}
