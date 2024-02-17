using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Charmander : Pokemon
    {
        public Charmander (int level) : base(level, 0.2) { }
        
        
        public override string ToString()
        {
            return "A level " + getLevel() + " Charmander";
        }
    }
}
