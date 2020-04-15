using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Computer : Player
    {
        public Computer()
        {
            name = "Computer";
        }
        // Will randomly select a gesture
        public override void ChooseGesture()
        {
            int i = RandomNumber();
            gesture = allGestures[i];            
        }
        //Generates a random int to plug into the ChooseGesture method
        public int RandomNumber()
        {
            Random random = new Random();
            int output = random.Next(0, allGestures.Count);
            return output;
        }
    }
}
