using System.Collections.ObjectModel;

namespace App.Mechanics
{
    public class Type
    {
        public Type()
        {

        }

        public int SkillsPerLevel { get; set; }

        public static Type Fighter
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public static Type Cleric
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public static Type Bard
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 6,
                };
            }
        }

        public static Type Barbarian
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 4,
                };
            }
        }

        public static Type Druid
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 4,
                };
            }
        }

        public static Type Monk
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 4,
                };
            }
        }

        public static Type Paladin
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public static Type Ranger
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 6,
                };
            }
        }

        public static Type Rogue
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 8,
                };
            }
        }

        public static Type Sorcerer
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public static Type Wizard
        {
            get
            {
                return new Type()
                {
                    SkillsPerLevel = 2,
                };
            }
        }

        public static Collection<Type> AllTypes = new Collection<Type>()
        {
            Type.Barbarian,
            Type.Bard,
            Type.Cleric,
            Type.Druid,
            Type.Fighter,
            Type.Monk,
            Type.Paladin,
            Type.Ranger,
            Type.Rogue,
            Type.Sorcerer,
            Type.Wizard,
        };
    }
}