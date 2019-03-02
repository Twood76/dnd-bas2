using System;
using Android.Text;
using Android.Widget;

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

            TextView heightDescriptor = new TextView(context)
            {
                Text = "The height of every button (in px): "
            };
            EditText height = new EditText(context)
            {
                InputType = Android.Text.InputTypes.ClassNumber,
                Text = Convert.ToString(context.Settings.ExpectedHeight)
            };
            height.TextChanged += (object sender, TextChangedEventArgs args) =>
            {
                try
                {
                    context.Settings.ExpectedHeight = Convert.ToInt32(height.Text);
                    context.SaveSettings();
                }
                catch (Exception) { }
            };
            this.AddView(heightDescriptor);
            this.AddView(height);
        }
    }
}