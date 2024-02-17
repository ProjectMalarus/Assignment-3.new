using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Bulbasaur : Pokemon
    {
        
        public Bulbasaur(int level) : base(level, 0.2) { }
        
            
        

        public override string ToString()
        {
            return "A level " + getLevel() + " Bulbasaur";
        }

    }
}
