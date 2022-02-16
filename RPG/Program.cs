using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Rogue James = new Rogue("James", 1);
            //Console.WriteLine(James.BasePrimaryAttributes.Strength);
            //Console.WriteLine(James.BasePrimaryAttributes.Dexterity);
            //Console.WriteLine(James.BasePrimaryAttributes.Intelligence);

            //James.IncreaseLevelBy(5);


            //Console.WriteLine(James.BasePrimaryAttributes.Strength);
            //Console.WriteLine(James.BasePrimaryAttributes.Dexterity);
            //Console.WriteLine(James.BasePrimaryAttributes.Intelligence);
            Weapon sharpAxe = new Weapon ( "sharpAxe", 2, Slots.Weapon, WeaponTypes.Axe);


            James.Equipment.EquipItem(sharpAxe);
        }
    }

    

}
