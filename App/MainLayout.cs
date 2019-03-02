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
            this.Orientation = GridOrientation.Vertical;
            this.AddView(MainLayout.MakeWithLayout(context, "Just the dice!", new DiceLayout(context)));
            this.AddView(MainLayout.MakeWithLayout(context, "Create new character", new CreationLayout(context)));
            this.AddView(MainLayout.MakeWithLayout(context, "Inspect existing character", new InspectLayout(context)));
            this.AddView(MainLayout.MakeWithLayout(context, "Settings", new SettingsLayout(context)));
        }

        private static Button MakeWithLayout(MainActivity context, string text, GridLayout nextLayout)
        {
            Button res = new Button(context);
            res.Click += (object sender, EventArgs args) => context.CurrentLayout = nextLayout;
            res.Text = text;
            res.SetWidth(context.Resources.DisplayMetrics.WidthPixels);
            res.SetHeight(context.Settings.ExpectedHeight);
            return res;
        }
    }
}