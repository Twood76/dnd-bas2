using Android.Widget;

namespace App
{
    public class CreationLayout : GridLayout
    {
        public CreationLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

        }
    }
}