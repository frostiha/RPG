using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Ranger : Hero
    {
        // initial Base Primary Attributes
        private int initialStrength = 1;
        private int initialDexterity = 7;
        private int initialIntelligence = 1;

        // Additional Base Primary Attributes points with each level up
        private int levelStrength = 1;
        private int levelDexterity = 5;
        private int levelIntelligence = 1;

        public Ranger(string name, int level) : base(name, level)
        {
            BasePrimaryAttributes = new BasePrimaryAttributes(initialStrength, initialDexterity, initialIntelligence,
                                                              levelStrength, levelDexterity, levelIntelligence, level);
        }
    }
}




// InvalidArmorException, only allow for these below
//• Rangers – Leather, Mail

// InvalidWeaponException, only allow for these below
//• Rangers – Bow