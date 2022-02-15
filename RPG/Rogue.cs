using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Rogue : Hero
    {
        // initial Base Primary Attributes
        int initialStrength = 2;
        int initialDexterity = 6;
        int initialIntelligence = 1;

        // Additional Base Primary Attributes points with each level up
        int levelStrength = 1;
        int levelDexterity = 4;
        int levelIntelligence = 1;


        public BasePrimaryAttributes BasePrimaryAttributes { get; set; }
        

        public Rogue()
        {
            BasePrimaryAttributes = new BasePrimaryAttributes();
        }



    }
}
