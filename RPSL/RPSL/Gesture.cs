using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    abstract class  Gesture
    {
        public string type;

        public abstract bool Compare(string type);//I didn't end up using any of these methods
                                                  
    }
}
