using Android.Widget;

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

        }
    }
}