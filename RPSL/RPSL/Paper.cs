﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Paper : Gesture
    {
        public Paper()
        {
            type = "Paper";
        }

        public override bool Compare(string playerTwo)
        {
            if (playerTwo == "Rock" || playerTwo == "Spock")
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
