using System.Collections.ObjectModel;

namespace App.DnD.Mechanics
{
    public class Race
    {
        public Race()
        {

        }

        public Attributes Attributes { get; set; }

        public string Identifier { get; set; }


        public static Race Human
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = 0,
                        Dexterity = 0,
                        Constitution = 0,
                        Intelligence = 0,
                        Wisdom = 0,
                        Charisma = 0,
                    },
                    Identifier = "Human",
                };
            }
        }

        public static Race Elf
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = 0,
                        Dexterity = 2,
                        Constitution = -2,
                        Intelligence = 0,
                        Wisdom = 0,
                        Charisma = 0,
                    },
                    Identifier = "Elf",
                };
            }
        }

        public static Race Dwarf
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = 0,
                        Dexterity = 0,
                        Constitution = 2,
                        Intelligence = 0,
                        Wisdom = 0,
                        Charisma = -2,
                    },
                    Identifier = "Dwarf",
                };
            }
        }

        public static Race Half_Elf
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = 0,
                        Dexterity = 0,
                        Constitution = 0,
                        Intelligence = 0,
                        Wisdom = 0,
                        Charisma = 0,
                    },
                    Identifier = "Half-Elf",
                };
            }
        }

        public static Race Half_Orc
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = 2,
                        Dexterity = 0,
                        Constitution = 0,
                        Intelligence = -2,
                        Wisdom = 0,
                        Charisma = -2,
                    },
                    Identifier = "Half-Orc",
                };
            }
        }

        public static Race Gnome
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = -2,
                        Dexterity = 0,
                        Constitution = 2,
                        Intelligence = 0,
                        Wisdom = 0,
                        Charisma = 0,
                    },
                    Identifier = "Gnome",
                };
            }
        }

        public static Race Halfling
        {
            get
            {
                return new Race()
                {
                    Attributes = new Attributes()
                    {
                        Strength = -2,
                        Dexterity = 2,
                        Constitution = 0,
                        Intelligence = 0,
                        Wisdom = 0,
                        Charisma = 0,
                    },
                    Identifier = "Halfling",
                };
            }
        }

        public static readonly Collection<Race> AllRaces = new Collection<Race>()
        {
            Race.Human,
            Race.Elf,
            Race.Half_Elf,
            Race.Half_Orc,
            Race.Gnome,
            Race.Dwarf,
            Race.Halfling
        };
    }
}