using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Functions
    {
        public int CharacterCreatorWH(string race)
        {
            if (race == "Human")
            {
                return 1;
            }

            if (race == "Dwarf")
            {
                return 2;
            }

            if (race == "Elf")
            {
                return 3;
            }

            if (race == "Halfling")
            {
                return 4;
            }

            if (race == "Random")
            {
                return 5;
            }
            else
                return 0;
        }
    }
}
