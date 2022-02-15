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
        int initialStrength = 1;
        int initialDexterity = 1;
        int initialIntelligence = 8;

        // Additional Base Primary Attributes points with each level up
        int levelStrength = 1;
        int levelDexterity = 1;
        int levelIntelligence = 5;
    }
}
