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
        private int initialStrength = 2;
        private int initialDexterity = 6;
        private int initialIntelligence = 1;

        // Additional Base Primary Attributes points with each level up
        private int levelStrength = 1;
        private int levelDexterity = 4;
        private int levelIntelligence = 1;

        private List<WeaponTypes> allowedWeaponTypes = new List<WeaponTypes> { WeaponTypes.Dagger, WeaponTypes.Sword };
        private List<ArmorTypes> allowedArmorTypes = new List<ArmorTypes> { ArmorTypes.Leather, ArmorTypes.Mail };

        public Rogue(string name, int level) : base(name, level)
        {
            BasePrimaryAttributes = new BasePrimaryAttributes(initialStrength,initialDexterity, initialIntelligence,
                                                              levelStrength, levelDexterity, levelIntelligence, level );
            Equipment = new Equipment();
        }

        //public void printTerminalWeaponTest(WeaponTypes weapon, Slots slot)
        //{
        //    if (allowedWeaponTypes.Contains(weapon) && slot == Slots.Weapon)
        //    {
        //        EquipItem(Slots slot, Item item);
        //        Console.WriteLine($"weapon: {weapon}, slot: {slot}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Either wrong weapon or slot.\nweapon: {weapon}, slot: {slot}");
        //    }
        //}
    }
}


// InvalidArmorException, only allow for these below
//• Rogues – Leather, Mail

// InvalidWeaponException, only allow for these below
//• Rogues – Dagger, Sword
