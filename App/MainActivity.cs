using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace App
{
    [Activity(Label = "DnDMaster", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private GridLayout _CurrentLayout;
        private GridLayout _LastLayout;

        public GridLayout CurrentLayout
        {
            get => this._CurrentLayout;
            set
            {
                if (this._CurrentLayout != null)
                    this._LastLayout = this._CurrentLayout;
                else
                    this._LastLayout = new MainLayout(this);
                this._CurrentLayout = value;
                SetContentView(this._CurrentLayout);
            }
        }

        public const string SettingsPath = "/storage/sdcard0/Android/data/DnDMaster/Settings.xml";

        private Stream SettingsStream = new FileStream(MainActivity.SettingsPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
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
            File.WriteAllBytes(MainActivity.SettingsPath, new byte[0]);
            this.SettingsStream = new FileStream(MainActivity.SettingsPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
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