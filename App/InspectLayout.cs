using Android.Widget;

namespace App
{
    public class InspectLayout : GridLayout
    {
        public InspectLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

        }
    }
}