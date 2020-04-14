using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
   abstract class Player
    {
        protected string name;
        public Gesture gesture;

        public Player()
        {
            
        }

        // Abstract method so both childrens' methods  react differently
        public abstract void ChooseGesture();
    }
}
