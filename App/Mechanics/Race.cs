namespace App.DnD.Mechanics
{
    public class Race
    {
        public Race()
        {

        }

        public Attributes Attributes { get; set; }


        public Race Human
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
                    }
                };
            }
        }

        public Race Elf
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
                    }
                };
            }
        }

        public Race Dwarf
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
                    }
                };
            }
        }

        public Race Half_Elf
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
                    }
                };
            }
        }

        public Race Half_Orc
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
                        Charisma =-2,
                    }
                };
            }
        }

        public Race Gnome
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
                    }
                };
            }
        }

        public Race Halfling
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
                    }
                };
            }
        }
    }
}