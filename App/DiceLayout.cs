using System;
using Android.Widget;

using App.DnD.Mechanics;

namespace App
{
    /// <summary>
    /// A layout just for rolling dice.
    /// </summary>
    public class DiceLayout : GridLayout
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="context"></param>
        public DiceLayout(MainActivity context)
            : base(context)
        {
            this.Orientation = GridOrientation.Vertical;

            this.AddView(DiceLayout.MakeWithCount(context, 20));
            this.AddView(DiceLayout.MakeWithCount(context, 12));
            this.AddView(DiceLayout.MakeWithCount(context, 10));
            this.AddView(DiceLayout.MakeWithCount(context, 8));
            this.AddView(DiceLayout.MakeWithCount(context, 6));
            this.AddView(DiceLayout.MakeWithCount(context, 4));
            this.AddView(DiceLayout.MakeWithCount(context, 100));

            // Maybe custom buttons should be created?
            //NumberPicker numberPicker = new NumberPicker(context);
            //numberPicker.MinValue = 0;
            //numberPicker.MaxValue = 1000;
            //numberPicker.V
            //this.AddView(numberPicker);
            //this.AddView(DiceLayout.MakeWithCount(context, numberPicker.Value));
        }

        /// <summary>
        /// A helper function
        /// </summary>
        /// <param name="con"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private static Button MakeWithCount(MainActivity con, int num)
        {
            Button res = new Button(con);
            string numString = Convert.ToString(num);
            res.Text = "Roll " + numString + ": na";
            res.Click += (object sender, EventArgs e) => res.Text = "Roll " + numString + 
                ": " + Convert.ToString(Dice.Roll(num)).PadLeft(numString.Length, '0');
            res.SetWidth(con.Resources.DisplayMetrics.WidthPixels);
            res.SetHeight(con.Settings.ExpectedHeight);
            return res;
        }
    }
}