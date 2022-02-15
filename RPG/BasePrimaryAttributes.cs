using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class BasePrimaryAttributes
    {
        private int strength = 0;
        private int dexterity = 0;
        private int intelligence = 0;
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }


        


        public BasePrimaryAttributes()
        {

        }

        public BasePrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }


        //// Upgrade by given varible for each level up for hero.
        public void UpdateLevel(int extraStrength, int extraDexterity, int extraIntelligence)
        {
            Strength += extraStrength;
            Dexterity += extraDexterity;
            Intelligence += extraIntelligence;
        }



    }
}
