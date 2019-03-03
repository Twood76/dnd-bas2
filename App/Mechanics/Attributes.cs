namespace App.DnD.Mechanics
{
    public class Attributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public static Attributes operator+(Attributes first, Attributes second)
        {
            return new Attributes()
            {
                Strength = first.Strength + second.Strength,
                Dexterity = first.Dexterity + second.Dexterity,
                Constitution = first.Constitution + second.Constitution,
                Wisdom = first.Wisdom + second.Wisdom,
                Intelligence = first.Intelligence + second.Intelligence,
                Charisma = first.Charisma + second.Charisma,
            };
        }
    }
}