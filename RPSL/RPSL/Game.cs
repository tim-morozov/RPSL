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
            if(selection == "Y")
            {
                playerTwo = new Human(); 
            }
            else
            {
                playerTwo = new Computer();
            }
        }
    }
}
