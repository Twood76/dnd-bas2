namespace App.DnD.Mechanics
{
    public class Armor
    {
        public const int STANDARD_VALUE = 10;

        public int Natural { get; set; }

        public int Shield { get; set; }

        public int Plate { get; set; }

        public int Dexterity { get; set; }

        public int Other { get; set; }

        public int Value
        {
            get
            {
                return this.Natural + this.Shield + this.Plate + this.Dexterity + this.Other;
            }
        }
    }
}