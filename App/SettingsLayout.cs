using System;
using Android.App;
using Android.Content;
using Android.Text;
using Android.Widget;

using App.DnD.Mechanics;

namespace App
{
    /// <summary>
    /// The layout used to control settings.
    /// </summary>
    public class SettingsLayout : GridLayout
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="context"></param>
        public SettingsLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

            Button heightButton = new Button(context)
            {
                Text = "Sets the height of every button in pixels. Current: " + Convert.ToString(context.Settings.ExpectedHeight),
            };
            heightButton.SetHeight(context.Settings.ExpectedHeight);
            heightButton.Click += (object sender, EventArgs args) =>
            {
                AlertDialog.Builder dialog = new AlertDialog.Builder(context);
                dialog.SetTitle("Button height");

                GridLayout num = new GridLayout(dialog.Context);
                EditText n = new EditText(dialog.Context)
                {
                    InputType = InputTypes.ClassNumber,
                    Text = Convert.ToString(context.Settings.ExpectedHeight)
                };
                num.AddView(n);
                dialog.SetView(num);

                dialog.SetPositiveButton("OK!", (object s, DialogClickEventArgs a) =>
                {
                    if (n.Text != "")
                    {
                        context.Settings.ExpectedHeight = Convert.ToInt32(n.Text);
                        context.SaveSettings();
                    }
                });
                dialog.Create().Show();
            };
            this.AddView(heightButton);

            Button reseedButton = new Button(context)
            {
                Text = "Reseeds the generator for random numbers using the current time."
            };
            reseedButton.SetHeight(context.Settings.ExpectedHeight);
            reseedButton.Click += (object sender, EventArgs args) => Dice.Reseed();
            this.AddView(reseedButton);
        }
    }
}