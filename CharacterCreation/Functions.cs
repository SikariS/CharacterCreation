using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Functions
    {
        //This function will be used for generating the main profiles
        public string mainProfileCreatorWH(string race)
        {
            int ws = randInt(22,40), bs = randInt(22, 40), s = randInt(22, 40), t = randInt(22, 40), ag = randInt(22, 40), intel = randInt(22, 40), wp = randInt(22, 40), fel = randInt(22, 40);
            string stat = "";

            if (race == "Human")
            {

                ;
            }

            if (race == "Dwarf")
            {
                ws += 10;
                t += 10;
                ag -= 10;
                fel -= 10;
            }

            if (race == "Elf")
            {
                bs += 10;
                ag += 10;
            }

            if (race == "Halfling")
            {
                ws -= 10;
                bs += 10;
                s -= 10;
                t -= 10;
                ag += 10;
                fel += 10;
            }

            else
            {

            }
            stat = "WS: " + ws + " BS: " + bs + " S: " + s + " T: " + t + " Ag: " + ag + " Int: " + intel + " WP: " + wp + " Fel: " + fel;
                return stat;
        }

        static Random r = new Random(); /*If this isn't static it will cause the same r.Next to be same (the whole main profile will be the same)
        because the random comes from time value and that is the same at the time of calling this function*/
        // Creates a number between min and max (max +1 because r.Next(1, 10) will give values from 1 to 9)
        public static int randInt(int min, int max)
        {
            return r.Next(min, max + 1);
        }

        //Function for generating a race (needs to know which game is used WH or SR)
        public string randRace(string game)
        {
            if (game == "WH")
            {   
                int random = randInt(1, 4);
                if (random == 1)
                {
                    return "Human";
                }
                if (random == 2)
                {
                    return "Dwarf";
                }
                if (random == 3)
                {
                    return "Elf";
                }
                if (random == 4)
                {
                    return "Halfling";
                }
                else
                    return "Human"; //This won't happen as long as the upper randomization works
            }
            else
                return "Human"; //TODO Shadowrun Races to be randomized as well
        }
    }
}
