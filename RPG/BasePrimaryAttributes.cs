using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class BasePrimaryAttributes
    {
        private int strength;
        private int dexterity;
        private int intelligence;
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }

        // Point by which attributes increment with each level.
        public int StrethLevelIncrement { get; set; }
        public int DexterityLevelIncrement { get; set; }
        public int IntelligenceLevelIncrement { get; set; }

        // Attributes points which Hero has at creation
        public int InitialStrength { get; set; }
        public int InitialDexterity { get; set; }
        public int InitialIntelligence { get; set; }


        // Might not need this method.
        public BasePrimaryAttributes()
        {

        }

        public BasePrimaryAttributes(int initialStrength, int initialDexterity, int initialIntelligence, int levelUpStrength, int levelUpDexterity, int levelUpIntelligence, int level)
        {
            InitialStrength = initialStrength;
            InitialDexterity = initialDexterity;
            InitialIntelligence = initialIntelligence;

            StrethLevelIncrement = levelUpStrength;
            DexterityLevelIncrement = levelUpDexterity;
            IntelligenceLevelIncrement = levelUpIntelligence;

            SetAttributesByLevel(level);
        }

        // Increases attributes as the level increases
        public void SetAttributesByLevel(int level)
        {
            Strength = InitialStrength + (level - 1) * StrethLevelIncrement;
            Dexterity = InitialDexterity + (level - 1) * DexterityLevelIncrement;
            Intelligence = InitialIntelligence + (level - 1) * IntelligenceLevelIncrement;
        }

    }
}
