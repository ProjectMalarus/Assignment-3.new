using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Caterpie : Pokemon
    {
        public Caterpie(int level) : base(level, 0.5) { }
        

        
        public override string ToString()
        {
            return "A level " + getLevel() + " Caterpie";
        }
    }
}
