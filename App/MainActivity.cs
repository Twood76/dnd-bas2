using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

using System.Xml.Serialization;
using System.IO;

namespace App
{
    /// <summary>
    /// The main actitvity.
    /// </summary>
    [Activity(Label = "DnDMaster", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private GridLayout _CurrentLayout;

        public GridLayout CurrentLayout
        {
            get => this._CurrentLayout;
            set
            {
                this._CurrentLayout = value;
                ScrollView scroller = new ScrollView(this);
                scroller.AddView(value);
                SetContentView(scroller);
            }
        }

        public const string MAIN_PATH = "/storage/sdcard0/Android/data/DnDMaster/";

        private Stream SettingsStream = new FileStream(MainActivity.MAIN_PATH + "Settings.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        private readonly XmlSerializer SettingsSerializer = new XmlSerializer(typeof(Settings));

        public Settings Settings { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.LoadSettings();
            // Set our view from the "main" layout resource.
            this.CurrentLayout = new MainLayout(this);
        }

        public void LoadSettings()
        {
            this.Settings = (Settings)this.SettingsSerializer.Deserialize(this.SettingsStream);
        }

        public void SaveSettings()
        {
            this.SettingsStream.Close();
            File.WriteAllBytes(MainActivity.MAIN_PATH + "Settings.xml", new byte[0]);
            this.SettingsStream = new FileStream(MainActivity.MAIN_PATH + "Settings.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            this.SettingsSerializer.Serialize(this.SettingsStream, this.Settings);
        }

        public override void OnBackPressed()
        {
            if (this.CurrentLayout is MainLayout)
                this.Finish();
            else
                this.CurrentLayout = new MainLayout(this);
        }
    }
}