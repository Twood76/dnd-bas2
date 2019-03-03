using Android.Widget;

using System;

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
        }

        /// <summary>
        /// A helper function
        /// </summary>
        /// <param name="con"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private static LinearLayout MakeWithCount(MainActivity con, int num)
        {
            int pixelWidth = con.Settings.ExpectedWidth;
            int pixelHeight = con.Settings.ExpectedHeight;
            LinearLayout linear = new LinearLayout(con)
            {
                Orientation = Android.Widget.Orientation.Horizontal,
            };
            string numString = Convert.ToString(num);


            Button res1 = new Button(con)
            {
                Text = "1x " + numString + ":\nna"
            };
            res1.SetWidth(pixelWidth / 2);
            res1.SetHeight(pixelHeight);
            res1.Click += (object sender, EventArgs e) => res1.Text = "1x " + numString +
                ":\n" + Convert.ToString(Dice.Roll(num));
            linear.AddView(res1);


            Button res2 = new Button(con)
            {
                Text = "2x " + numString + ":\nna",
            };
            res2.SetWidth(pixelWidth / 4);
            res2.SetHeight(pixelHeight);
            res2.Click += (object sender, EventArgs e) =>
                res2.Text = "2x " + numString + ":\n" + Convert.ToString(Dice.Roll(num) + Dice.Roll(num));
            linear.AddView(res2);


            Button res3 = new Button(con)
            {
                Text = "4x " + numString + ":\nna",
            };
            res3.SetWidth(pixelWidth / 4);
            res3.SetHeight(pixelHeight);
            res3.Click += (object sender, EventArgs e) =>
                res3.Text = "4x " + numString + ":\n" + Convert.ToString(Dice.Roll(num) + Dice.Roll(num) + Dice.Roll(num) + Dice.Roll(num));
            linear.AddView(res3);

            return linear;
        }
    }
}