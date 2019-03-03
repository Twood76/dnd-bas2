using Android.App;
using Android.Content;
using Android.Widget;

using System;
using System.Collections.ObjectModel;

using App.DnD.Mechanics;

namespace App
{
    /// <summary>
    /// The layout for character creation.
    /// </summary>
    public class CreationLayout : GridLayout
    {
        /// <summary>
        /// Basic constructor.
        /// </summary>
        /// <param name="context"></param>
        public CreationLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

            Character character = new Character();

            Button raceButton = new Button(context)
            {
                Text = "Race: na",
            };
            raceButton.SetWidth(context.Settings.ExpectedWidth);
            raceButton.SetHeight(context.Settings.ExpectedHeight);
            raceButton.Click += (object sender, EventArgs e) =>
            {
                string selectedString;

                AlertDialog.Builder builder = new AlertDialog.Builder(context);
                GridLayout gridLayout = new GridLayout(context)
                {
                    Orientation = GridOrientation.Vertical,
                };
                foreach (Race rac in Race.AllRaces)
                {
                    Button selectButton = new Button(context)
                    {
                        Text = rac.Identifier,
                    };
                    selectButton.SetHeight(context.Settings.ExpectedHeight);
                    selectButton.SetWidth(context.Settings.ExpectedWidth);
                    selectButton.Click += (object asvfas, EventArgs asfasf) =>
                    {
                        selectedString = selectButton.Text;
                        raceButton.Text = "Race: " + selectButton.Text;
                        character.Race = rac;
                    };
                    gridLayout.AddView(selectButton);
                }
                ScrollView scroller = new ScrollView(context);
                scroller.AddView(gridLayout);
                builder.SetView(scroller);
                builder.Create().Show();
            };
            this.AddView(raceButton);
        }
    }
}