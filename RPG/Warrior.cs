using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior: Hero
    {

        // initial Base Primary Attributes
        private int initialStrength = 5;
        private int initialDexterity = 2;
        private int initialIntelligence = 1;

        // Additional Base Primary Attributes points with each level up
        private int levelStrength = 3;
        private int levelDexterity = 2;
        private int levelIntelligence = 1;

        public Warrior(string name, int level) : base(name, level)
        {
            BasePrimaryAttributes = new BasePrimaryAttributes(initialStrength, initialDexterity, initialIntelligence,
                                                              levelStrength, levelDexterity, levelIntelligence, level);
        }
    }
}



// InvalidArmorException, only allow for these below
//• Warriors – Mail, Plate