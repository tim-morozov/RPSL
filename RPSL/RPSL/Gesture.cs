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

       public abstract bool Compare();
    }
}
