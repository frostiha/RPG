using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Item
    {
        public string Name { get; set; }
        public int LevelRequirement { get; set; }
        public Slots Slot { get; set; }
        


        public Item(string name, int leveRequirement, Slots slot)
        {
            Name = name;
            LevelRequirement = leveRequirement;
            Slot = slot;
        }
    }
}


