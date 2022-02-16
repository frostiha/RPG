using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    enum WeaponTypes { Axe, Bow, Dagger, Hammer, Staff, Sword, Wand }
    class Weapon : Item
    {
        public WeaponTypes SelectedWeaponType { get; set; }

        public Weapon(string name, int leveRequirement, Slots slot, WeaponTypes selectedWeaponType) : base(name, leveRequirement, slot)
        {
            Name = name;
            SelectedWeaponType = selectedWeaponType;
            LevelRequirement = leveRequirement;
            Slot = slot;
        }
    }
}

// InvalidWeaponException, only allow for these below
//Mages – Staff, Wand
//• Rangers – Bow
//• Rogues – Dagger, Sword
//• Warriors – Axe, Hammer, Sword
