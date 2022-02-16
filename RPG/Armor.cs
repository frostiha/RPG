using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    enum ArmorTypes { Cloth, Leather, Mail, Plate }
    class Armor : Item
    {

        public ArmorTypes SelectedArmor { get; set; }

        public WeaponTypes SelectedWeapon { get; set; }

        public Armor(string name, int leveRequirement, Slots slot, ArmorTypes selectedArmor) : base(name, leveRequirement, slot)
        {
            Name = name;
            LevelRequirement = leveRequirement;
            Slot = slot;
            SelectedArmor = selectedArmor;
        }

    }
}

// InvalidArmorException, only allow for these below
//• Mages – Cloth
//• Rangers – Leather, Mail
//• Rogues – Leather, Mail
//• Warriors – Mail, Plate
