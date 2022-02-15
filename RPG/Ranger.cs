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
        int initialStrength = 1;
        int initialDexterity = 7;
        int initialIntelligence = 1;

        // Additional Base Primary Attributes points with each level up
        int levelStrength = 1;
        int levelDexterity = 5;
        int levelIntelligence = 1;
    }
}
