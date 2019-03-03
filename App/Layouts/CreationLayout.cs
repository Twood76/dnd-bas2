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
                Collection<string> strings = new Collection<string>()
                {
                    "Human",
                    "Elf",
                    "Half_Elf",
                    "Half_Orc",
                    "Gnome",
                    "Dwarf",
                    "Halfling"
                };

                EditText raceText = new EditText(context)
                {
                    Text = "e. g. Half_Elf"
                };

                AlertDialog.Builder builder = new AlertDialog.Builder(context);
                builder.SetView(raceText);
                builder.SetPositiveButton("OK!", (object ssender, DialogClickEventArgs sargs) =>
                {
                    if (strings.Contains(raceText.Text))
                    {
                        switch (raceText.Text)
                        {
                            case "Human":
                                character.Race = Race.Human;
                                break;
                            case "Elf":
                                character.Race = Race.Elf;
                                break;
                            case "Half_Elf":
                                character.Race = Race.Half_Elf;
                                break;
                            case "Half_Orc":
                                character.Race = Race.Half_Orc;
                                break;
                            case "Gnome":
                                character.Race = Race.Gnome;
                                break;
                            case "Dwarf":
                                character.Race = Race.Dwarf;
                                break;
                            case "Halfling":
                                character.Race = Race.Halfling;
                                break;
                        }
                        raceButton.Text = "Race: " + raceText.Text;
                    }
                    else
                    {
                        character.Race = Race.Human;
                        raceButton.Text = "Race: Human";
                    }
                });
                builder.Create().Show();
            };
            this.AddView(raceButton);
        }
    }
}