namespace App.Mechanics
{
    public class Type
    {
        public Type()
        {

        }

        public int SkillsPerLevel { get; set; }

        public Type Fighter
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public Type Cleric
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public Type Bard
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 6,
                };
            }
        }

        public Type Barbarian
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 4,
                };
            }
        }

        public Type Druid
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 4,
                };
            }
        }

        public Type Monk
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 4,
                };
            }
        }

        public Type Paladin
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public Type Ranger
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 6,
                };
            }
        }

        public Type Rogue
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 8,
                };
            }
        }

        public Type Sorcerer
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public Type Wizard
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }
    }
}