using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
   abstract class Player
    {
        public List<Gesture> allGestures;
        protected string name;
        public Gesture gesture;

        public Player()
        {
            allGestures = new List<Gesture>() { new Rock(), new Paper(), new Lizard(), new Scissors(), new Spock()};  
        }

        // Abstract method so both childrens' methods  react differently
        public abstract void ChooseGesture();
    }
}
