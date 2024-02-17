using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal abstract class Pokemon
    {
        private int level;
        private double baseCatchRate;

        public Pokemon(int lvl, double catchRate)
        {
            level = lvl;
            baseCatchRate = catchRate;
        }

        public int getLevel()
        {
            return level;
        }

        public double getBaseCatchRate()
        {
            return baseCatchRate;
        }
    }
}
