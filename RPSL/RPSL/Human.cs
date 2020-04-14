using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    class Human : Player
    {

        public Human()
        {
            name = AddName();
        }

        public string AddName()
        {
            Console.WriteLine("Write your name!");
            string input = Console.ReadLine();
            return input;
        }
    }
}
