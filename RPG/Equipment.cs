using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public enum Slots { Head, Body, Legs, Weapon}
    class Equipment
    {
        public Item Item { get; set; }
        public Dictionary<Slots, Armor> HeroArmor { get; set; }
        public Dictionary<Slots, Weapon> HeroWeapon { get; set; }
        public Dictionary<Slots, Item> HeroEquipment { get; set; }

        public Equipment()
        {

        }

        public void EquipItem(Item item)
        {
            if(item.GetType() == typeof(Weapon))
            {
                Console.WriteLine("EquipItem YES if statement.");

                Weapon sharpAxer = new Weapon("sharpAxe", 2, Slots.Weapon, WeaponTypes.Axe);
                //HeroWeapon.Add(item.Slot, sharpAxer);


                Console.WriteLine(HeroWeapon);
            }
            else if (item.GetType() == typeof(Armor))
            {
                Console.WriteLine("Else statement");
            }

            //
        }

    }
}

// armor in slots: Head, Body, Legs
// 

//Name = name;
//LevelRequirement = leveRequirement;
//Slot = slot;