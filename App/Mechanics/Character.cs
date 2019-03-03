using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.DnD.Mechanics
{
    public class Character
    {
        public Character(Attributes attributes, Armor armor, Race race, Misc misc, Type type)
        {
            this.Attributes = attributes;
            this.Armor = armor;
            this.Race = race;
            this.Misc = misc;
            this.Type = type;
        }

        public Attributes Attributes { get; set; }
        
        public Armor Armor { get; set; }

        public Race Race { get; set; }

        public Misc Misc { get; set; }

        public Type Type { get; set; }
    }
}