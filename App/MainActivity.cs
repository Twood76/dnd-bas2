using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource.
            this.CurrentLayout = new MainLayout(this);
        }

        public override void OnBackPressed()
        {
            if (this.CurrentLayout is MainLayout)
            {
                this.Finish();
            }
            else
            {
                this.CurrentLayout = this._LastLayout;
            }
        }
    }
}