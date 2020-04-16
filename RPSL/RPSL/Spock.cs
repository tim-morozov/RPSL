using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Spock : Gesture
    {

        public Spock()
        {
            type = "Spock";
        }

        public override bool Compare(string playerTwo)
        {
            if (playerTwo == "Sciccors" || playerTwo == "Rock")
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
