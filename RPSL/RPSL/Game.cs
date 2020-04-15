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
        public int playerOneScore = 0;
        public int playerTwoScore = 0;

        public Game()
        {
            playerOne = new Human();
        }
        //Allows Human player to select if they want to play against the Computer
        //based on user input
        public void ChooseMultiplayer()
        {
            Console.WriteLine("Would you like to play with a friend? Y or N");
            string selection = Console.ReadLine();
            selection = selection.ToLower(); //So no matter what case the user writes it can always evaluate properly
            if(selection == "y")
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
                Console.WriteLine(i + ")" + playerOne.allGestures[i].type);
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
        //Resets player score before and after game
        public void ResetScore()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        //Conducts one round of gameplay
        public void Round(Player playerOne, Player playerTwo)
        {
            playerOne.gesture = playerOne.ChooseGesture();
            if(playerTwo.name == "Computer")
            {
               playerTwo.gesture = playerTwo.ChooseGesture();
            }
            else
            {
                playerTwo.gesture = playerTwo.ChooseGesture();
            }
            Console.WriteLine(playerOne.name + " chose " + playerOne.gesture.type);
            Console.WriteLine(playerTwo.name + " chose " + playerTwo.gesture.type);
        }

        public void CompareGestures(Gesture pOne, Gesture pTwo)
        {
            if(pOne.type == "Rock")
            {
                bool output = pTwo.Compare();

            }

        }

        public void RunGame()
        {
            ResetScore();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizzard, Spock!");
            ChooseMultiplayer();
            DisplayRules();            
            Round(playerOne, playerTwo);
        
            

        }
    }
}
