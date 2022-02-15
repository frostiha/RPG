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
        int initialStrength = 5;
        int initialDexterity = 2;
        int initialIntelligence = 1;

        // Additional Base Primary Attributes points with each level up
        int levelStrength = 3;
        int levelDexterity = 2;
        int levelIntelligence = 1;
    }
}
