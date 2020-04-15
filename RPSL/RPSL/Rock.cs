using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Rock : Gesture
    {
        public Rock()
        {
            type = "Rock";
        }

        public bool Compare(string playerTwo)
        {
            if(playerTwo == "Scissors" || playerTwo == "Lizard" )
            {
                return true;   
            }
            else
            {
                return false;
            }
        }
    }
}
