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
        public Gesture rock = new Rock();
        public Gesture paper = new Paper();
        public Gesture scissors = new Scissors();
        public Gesture lizard = new Lizard();
        public Gesture spock = new Spock();

        public Player()
        {
            allGestures = new List<Gesture>();
            allGestures.Add(rock);    
            allGestures.Add(paper);    
            allGestures.Add(lizard);    
            allGestures.Add(scissors);    
            allGestures.Add(spock);    
        }

        // Abstract method so both childrens' methods  react differently
        public abstract void ChooseGesture();

        
    }
}
