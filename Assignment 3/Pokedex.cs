using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Pokedex
    {
        private List<Pokemon> myPokedex_of_Pokemon = new List<Pokemon>();

        public void addToDex(Pokemon p)
        {
            myPokedex_of_Pokemon.Add(p);
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach (Pokemon pokemon in myPokedex_of_Pokemon)
            {
                if (pokemon is Bulbasaur)
                {
                    Bulbasaur b = (Bulbasaur)pokemon;
                    output += b.ToString();
                }
                else if (pokemon is Caterpie)
                {
                    Caterpie c = (Caterpie)pokemon;
                    output += c.ToString();
                }
                else if (pokemon is Charmander)
                {
                    Charmander m = (Charmander)pokemon;
                    output += m.ToString();
                }
            }
            return output;
        }
    }
}
