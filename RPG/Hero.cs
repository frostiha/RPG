using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    abstract class Hero
    {

        // to do 
        // overload + operator for


        private string name;
        private int level;
        private int[] basePrimaryAttributes;
        private int[] totalPrimaryAttributes;


        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }

        public BasePrimaryAttributes BasePrimaryAttributes { get; set; }

        


        // constructor that takes no arguments:
        public Hero()
        {
            BasePrimaryAttributes = new BasePrimaryAttributes();
        }

        // constructor that takes one argument:
        public Hero(string name)
        {
            Name = name;
            BasePrimaryAttributes = new BasePrimaryAttributes();
        }



    }
}