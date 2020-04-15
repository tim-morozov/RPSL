using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int playerOneScore = 0;
        int playerTwoScore = 0;
        List<string> gestureList;

        public Game()
        {
            playerOne = new Human();
            gestureList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
        //Allows Human player to select if they want to play against the Computer
        //based on user input
        public void ChooseMultiplayer()
        {
            Console.WriteLine("Would you like to play with a friend? Y or N");
            string selection = Console.ReadLine();
            if(selection == "Y")
            {
                playerTwo = new Human(); 
            }
            else
            {
                playerTwo = new Computer();
            }
        }
        //Displays basic game rules
        public void DisplayRules()
        {
            Console.WriteLine("The game will be played until one player has won 3 times \n You will choose 1 of 5 options");
            for(int i = 0; i < playerOne.allGestures.Count; i++)
            {
                Console.WriteLine(i + ")" + gestureList[i]);
            }
            Console.WriteLine("The rules for each gesture are:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");

        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizzard, Spock");
            DisplayRules();
            ChooseMultiplayer();

        }
    }
}
