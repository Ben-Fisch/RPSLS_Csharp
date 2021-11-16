using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class User : Player
    {
        public User(string name)
        {
            this.name = name;
            
        }

        public string ChooseGesture()
        {
            bool validInput = false;
            while(validInput != true)
            {
                Console.WriteLine("Please choose your throw '0' for rock, '1' for paper, '2' for scissors, '3' for lizard, '4' for spock.");
                string choice = Console.ReadLine();
                if(choice == "0")
                {
                   choice = "Rock";
                   validInput = true;
                }
                else if(choice == "1")
                {
                    choice = "Paper";
                    validInput = true;
                }
                else if(choice == "2")
                {
                    choice = "Scissors";
                    validInput = true;
                }
                else if (choice == "3")
                {
                    choice = "Lizard";
                    validInput = true;
                }
                else if (choice == "4")
                {
                    choice = "Spock";
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select again.");
                }
                return choice;
            }

        }
    }
}
