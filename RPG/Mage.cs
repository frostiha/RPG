using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Mage : Hero
    {
        // initial Base Primary Attributes
        private int initialStrength = 1;
        private int initialDexterity = 1;
        private int initialIntelligence = 8;

        // Additional Base Primary Attributes points with each level up
        private int levelStrength = 1;
        private int levelDexterity = 1;
        private int levelIntelligence = 5;

        public Mage(string name, int level) : base(name, level)
        {
            BasePrimaryAttributes = new BasePrimaryAttributes(initialStrength, initialDexterity, initialIntelligence,
                                                              levelStrength, levelDexterity, levelIntelligence, level);
        }
    }
}




// InvalidArmorException, only allow for these below
//• Mages – Cloth


// InvalidWeaponException, only allow for these below
//Mages – Staff, Wand