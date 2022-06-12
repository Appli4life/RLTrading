using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Navigation;

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
        public static List<Color> Colors = new()
        {
                new Color("Default", Brushes.Transparent),
                new Color("Black", Brushes.Black),
                new Color("White", Brushes.White),
                new Color("Grey", Brushes.Gray),
                new Color("Crimson", Brushes.Crimson),
                new Color("Pink", Brushes.Pink),
                new Color("Cobalt", Brushes.Blue),
                new Color("Sky Blue", Brushes.SkyBlue),
                new Color("Sienna", Brushes.Sienna),
                new Color("Saffron", Brushes.Yellow),
                new Color("Lime", Brushes.Lime),
                new Color("Green", Brushes.ForestGreen),
                new Color("Orange", Brushes.Orange),
                new Color("Purple", Brushes.Purple)
            };
        #endregion
    }
}