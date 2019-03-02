using System;

namespace App.DnD.Mechanics
{
    /// <summary>
    /// This class is mostly used as a static class; Dice.Roll(int) will be sufficient for most tasks,
    /// however if you want to modify chances for specific numbers, instantiate Dice with given chances.
    /// </summary>
    public class Dice
    {
        #region static
        /// <summary>
        /// Intern generator for integers.
        /// </summary>
        private static Random Generator = new Random();

        /// <summary>
        /// Provides a wrapper for System.Random.
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        public static int Roll(int sides)
        {
            //Read IntelliSense method description
            return Dice.Generator.Next(sides) + 1;
        }

        /// <summary>
        /// Sets the current generator's time to a new seed.
        /// </summary>
        public static void Reseed()
        {
            Dice.Generator = new Random(DateTime.Now.Millisecond);
        }
        #endregion

        /// <summary>
        /// This array contains the relative chances for each number. If all values are 0 except one,
        /// this one will be chosen every time.
        /// </summary>
        public int[] Chances { get; set; }

        /// <summary>
        /// The number of sides which an instance of dice has.
        /// </summary>
        public int Sides { get; set; }
        
        /// <summary>
        /// Default.
        /// </summary>
        public Dice()
        {
            this.Sides = 2;
            this.Chances = new int[2] { 1, 1 };
        }

        /// <summary>
        /// Make a new Dice from given arguments.
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="chances"></param>
        public Dice(int sides, int[] chances)
        {
            this.Sides = sides;

            // Out-of-bounds-checking
            if (chances.Length != sides)
                throw new ArgumentOutOfRangeException("chances", chances, "chances.Length is not equal to sides");

            this.Chances = chances;
        }

        /// <summary>
        /// Rolls the dice using it's chances.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            // Caluclate the sum of all elements in this.Chances.
            int sum = 0;
            foreach (int x in this.Chances)
                sum += x;

            // Generate random number in sum.
            int rolled = Dice.Generator.Next(sum);

            // The number which will be returned.
            int res = 1;
            // Iterate through elements in array.
            foreach (int x in this.Chances)
            {
                // Subtract chance for current element.
                rolled -= x;
                // If forementioned subtraction makes rolled less than zero, then res has reached it's destionation.
                if (rolled < 0)
                    return res;
                // Don't forget to increment res.
                res++;
            }
            // I don't know why this does NOT work
            throw new Exception("Something went wrong in <DiceInstance>.Roll()");
        }
    }
}