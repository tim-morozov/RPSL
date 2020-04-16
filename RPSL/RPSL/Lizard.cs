using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Lizard : Gesture
    {
        public Lizard()
        {
            type = "Lizard";
        }

        public override bool Compare(string playerTwo)
        {
            if (playerTwo == "Paper" || playerTwo == "Lizard")
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
