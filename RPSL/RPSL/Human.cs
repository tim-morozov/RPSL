using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Human : Player
    {

        public Human()
        {
            name = AddName();
        }

        public string AddName()
        {
            Console.WriteLine("Write your name!");
            string input = Console.ReadLine();
            return input;
        }
        //Works off user input only for Human players
        public override Gesture ChooseGesture()
        {
            Console.WriteLine("Please choose a gesture:");
            for (int i = 0; i < allGestures.Count; i++)
            {
                Console.WriteLine(i + ")" + allGestures[i].type);
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            Gesture chosenGesture = allGestures[choice];
            return chosenGesture;

        }
    }
}
