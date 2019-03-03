using Android.Widget;

namespace App
{
    /// <summary>
    /// A layout for using the character; Roll on skills, change attributes etc.
    /// </summary>
    public class InspectLayout : GridLayout
    {
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="context"></param>
        public InspectLayout(MainActivity context) :
            base(context)
        {
            this.Orientation = GridOrientation.Vertical;

        }
    }
}