using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    class Functions
    {
        //This function will be used for generating the main profiles for Warhammer
        public string MainProfileCreatorWH(string race)
        {
            int ws = randInt(22,40), bs = randInt(22, 40), s = randInt(22, 40), t = randInt(22, 40), ag = randInt(22, 40), intel = randInt(22, 40), wp = randInt(22, 40), fel = randInt(22, 40), wounds;
            string stat = "";

            if (race == "Human")
            {
                wounds = randInt(10, 13);
            }

            if (race == "Dwarf")
            {
                ws += 10;
                t += 10;
                ag -= 10;
                fel -= 10;
                wounds = randInt(11, 14);
            }

            if (race == "Elf")
            {
                bs += 10;
                ag += 10;
                wounds = randInt(9, 12);
            }

            if (race == "Halfling")
            {
                ws -= 10;
                bs += 10;
                s -= 10;
                t -= 10;
                ag += 10;
                fel += 10;
                wounds = randInt(8, 11);
            }

            else
            {
                wounds = randInt(10, 13);
            }
            int sb = s / 10; //Strength Bonus is the first digit (or the tenth) in Strength (for example with S 38 SB is 3)
            int tb = t / 10; //Toughness Bonus is the first digit (or the tenth) in Toughness
            stat = "WS: " + ws + " BS: " + bs + " S: " + s + " T: " + t + " Ag: " + ag + " Int: " + intel + " WP: " + wp + " Fel: " + fel +
                " SB: " + sb + " TB: " + tb + " W: " + wounds;
                return stat;
        }

        public string MainProfileCreatorSR(string race)
        {
            int body = randInt(1, 6), agi = randInt(1, 6), rea = randInt(1, 6), str = randInt(1, 6), cha = randInt(1, 6), intuition = randInt(1, 6), log = randInt(1, 6), wil = randInt(1, 6), ini;
            string stat = "";

            if (race == "Human")
            {
                
            }

            if (race == "Dwarf")
            {
                body++;
                if (rea == 6)
                {
                    rea -= 1; //Dwarf rea is between 1-5
                }
                str += 2;
                wil++;
            }

            if (race == "Elf")
            {
                agi++;
                cha += 2;

            }

            if (race == "Orc")
            {
                body += 3;
                str += 2;
                if (cha == 6)
                {
                    cha -= 1; //Orc cha is between 1-5
                }
                if (log == 6)
                {
                    log -= 1; //Orc log is between 1-5
                }

            }

            if (race == "Troll")
            {
                body += 4;
                if (agi == 6)
                {
                    agi -= 1; //Troll agi is between 1-5
                }
                str += 4;
                if (cha == 6)
                    cha -= 2; //Troll cha is between 1-4
                else if (cha == 5)
                    cha--;
                if (intuition == 6) //Troll intuition is between 1-5
                    intuition--;
                if (log == 6)//Troll log is between 1-5
                    log--;
            }
            
            ini = rea + intuition;
            int physicalDamageTrack = 8 + body / 2; //Physical Damage Track is 8 Body / 2 (rounded up)
            int stunDamageTrack = 8 + wil / 2; //Stun Damage Track is 8 Willpower / 2 (rounded up)
            stat = "Body: " + body + " AGI: " + agi + " REA: " + rea + " STR: " + str + " CHA: " + cha + " Int: " + intuition + " LOG: " + log + " WIL: " + wil +
                " INI: " + ini + " Physical DMG: " + physicalDamageTrack + " Stun DMG: " + stunDamageTrack;
            return stat;
        }

        //Print the txt file to the folder the program is running from (currently Debug folder)
        public void PrintToFile(string print)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Characters.txt", true))
            {
                file.WriteLine(print);
            }
            //System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Characters.txt", print);
        }

        /*If this isn't static it will cause the r.Next which are called at the same time to be the same (the whole main profile will be the same)
        because the random comes from time value and that is the same at the time of calling this function*/
        static Random r = new Random();

        // Creates a number between min and max (max +1 because r.Next(1, 10) will give values from 1 to 9)
        public static int randInt(int min, int max)
        {
            return r.Next(min, max + 1);
        }

        //Function for generating a race (needs to know which game is used WH or SR)
        public string RandRace(string game)
        {
            int random;
            if (game == "WH")
            {   
                random = randInt(1, 4);
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

            if (game == "SR")
            {
                    random = randInt(1, 5);
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
                        return "Orc";
                    }
                    if (random == 5)
                    {
                        return "Troll";
                    }
                    else
                        return "Troll"; //This won't happen as long as the upper randomization works
                } else
                return "Dwarf";
        }
    }
}
