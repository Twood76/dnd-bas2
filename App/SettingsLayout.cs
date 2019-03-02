using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;

namespace App
{
    public class SettingsLayout : GridLayout
    {
        public SettingsLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

            EditText height = new EditText(context)
            {
                InputType = Android.Text.InputTypes.ClassNumber
            };
            height.TextChanged += (object sender, TextChangedEventArgs args) => 
            {
                context.Settings.ExpectedHeight = Convert.ToInt32(height.Text);
                context.SaveSettings();
            };
            this.AddView(height);
        }
    }
}