using System;
using Android.Widget;

namespace App
{
    /// <summary>
    /// The layout seen when the application starts up
    /// </summary>
    public class MainLayout : GridLayout
    {
        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="context"></param>
        public MainLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

            this.AddView(MainLayout.MakeWithLayout(context, "Just the dice!", new DiceLayout(context)));
            this.AddView(MainLayout.MakeWithLayout(context, "Create new character", new CreationLayout(context)));
            this.AddView(MainLayout.MakeWithLayout(context, "Inspect existing character", new InspectLayout(context)));
            this.AddView(MainLayout.MakeWithLayout(context, "Settings", new SettingsLayout(context)));
        }

        /// <summary>
        /// A helper function
        /// </summary>
        /// <param name="context"></param>
        /// <param name="text"></param>
        /// <param name="nextLayout"></param>
        /// <returns></returns>
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