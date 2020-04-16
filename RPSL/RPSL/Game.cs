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
        int numberOfRounds = 3;

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
            Console.WriteLine("The game will be in a best of 3 format \n You will choose 1 of 5 options");
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
            if(pOne.type == pTwo.type)
            {
                Console.WriteLine("You tied!");
                Round(playerOne, playerTwo);
            }
            else if(pOne.type == "Rock") 
            {
                RockCompare(pTwo.type);
                Console.WriteLine(playerOne.name + " score: " + playerOneScore);
                Console.WriteLine(playerTwo.name + " score: " + playerTwoScore);
            }
            else if(pOne.type == "Paper")
            {
                PaperCompare(pTwo.type);
                Console.WriteLine(playerOne.name + " score: " + playerOneScore);
                Console.WriteLine(playerTwo.name + " score: " + playerTwoScore);
            }
            else if(pOne.type == "Scissors")
            {
                ScissorsCompare(pTwo.type);
                Console.WriteLine(playerOne.name + " score: " + playerOneScore);
                Console.WriteLine(playerTwo.name + " score: " + playerTwoScore);
            }
            else if(pOne.type == "Lizard")
            {
                LizzardCompare(pTwo.type);
                Console.WriteLine(playerOne.name + " score: " + playerOneScore);
                Console.WriteLine(playerTwo.name + " score: " + playerTwoScore);
            }
            else if(pOne.type == "Spock")
            {
                SpockCompare(pTwo.type);
                Console.WriteLine(playerOne.name + " score: " + playerOneScore);
                Console.WriteLine(playerTwo.name + " score: " + playerTwoScore);
            }
            else
            {
                Console.WriteLine("Try again!");
            }

        }
        
        public void RockCompare(string pTwo)
        {
            if(pTwo == "Scissors" || pTwo == "Lizard")
            {
                playerOneScore++;
            }
            else
            {
                playerTwoScore++;
            }
        }

        public void PaperCompare(string pTwo)
        {
            if (pTwo == "Rock" || pTwo == "Scissors")
            {
                playerOneScore++;
            }
            else
            {
                playerTwoScore++;
            }
        }
        public void ScissorsCompare(string pTwo)
        {
            if (pTwo == "Paper" || pTwo == "Lizard")
            {
                playerOneScore++;
            }
            else
            {
                playerTwoScore++;
            }
        }
        public void LizzardCompare(string pTwo)
        {
            if (pTwo == "Spock" || pTwo == "Paper")
            {
                playerOneScore++;
            }
            else
            {
                playerTwoScore++;
            }
        }

        public void SpockCompare(string pTwo)
        {
            if (pTwo == "Scissors" || pTwo == "Rock")
            {
                playerOneScore++;
            }
            else
            {
                playerTwoScore++;
            }
        }

        public void DeclareWinner()
        {
            if(playerOneScore > playerTwoScore)
            {
                Console.WriteLine(playerOne.name + " is the winner!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " is the winner!");
            }
        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? Y or N");
            string input = Console.ReadLine();
             input = input.ToLower(); //To evaluate the input no matter which case the user types
            if(input == "y")
            {
                RunGame();
            }
            else
            {
                Console.WriteLine("Have a nice day!");
            }
        }


        public void RunGame()
        {
            ResetScore();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizzard, Spock!");
            ChooseMultiplayer();
            DisplayRules();
            for (int i = 0; i <= numberOfRounds; i++)
            {
                Round(playerOne, playerTwo);
                CompareGestures(playerOne.gesture, playerTwo.gesture);
            }
            DeclareWinner();
            PlayAgain();
        }
    }
}
