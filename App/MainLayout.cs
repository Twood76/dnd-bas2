using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7;
using Android.Util;

namespace App
{
    public class MainLayout : GridLayout
    {
        public MainLayout(MainActivity context) :
            base(context)
        {
            Button diceButton = new Button(context);
            diceButton.Click += (object sender, EventArgs args) => context.CurrentLayout = new DiceLayout(context);
            diceButton.Text = "Just the dice!";
            this.AddView(diceButton);


        }
    }
}