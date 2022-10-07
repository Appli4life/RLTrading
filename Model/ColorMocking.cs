using System.Collections.Generic;
using System.Windows.Media;

namespace RLTrading.Model
{
    /// <summary>
    /// Color Mocking
    /// </summary>
    public static class ColorMocking
    {
        #region Property

        /// <summary>
        /// Liste mit Colors
        /// </summary>
        public static readonly List<Color> Colors = new()
        {
                new Color("Default", Brushes.Transparent),
                new Color("Black", Brushes.Black),
                new Color("Titanium White", Brushes.White),
                new Color("Grey", Brushes.Gray),
                new Color("Crimson", Brushes.Crimson),
                new Color("Pink", Brushes.Pink),
                new Color("Cobalt", Brushes.Blue),
                new Color("Sky Blue", Brushes.SkyBlue),
                new Color("Burnt Sienna", Brushes.Sienna),
                new Color("Saffron", Brushes.Yellow),
                new Color("Lime", Brushes.Lime),
                new Color("Forest Green", Brushes.ForestGreen),
                new Color("Orange", Brushes.Orange),
                new Color("Purple", Brushes.Purple),
                new Color("Gold", Brushes.Gold),
            };
        #endregion
    }
}