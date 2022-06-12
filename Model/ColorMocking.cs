using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// Holt Liste von Farben
        /// </summary>
        /// <returns>Liste mit Farben (neu erstellt)</returns>
        public static List<Color> GetQualities()
        {
            List<Color> list = new List<Color>
            {
                new("Default"),
                new("Black"),
                new("White"),
                new("Grey"),
                new("Crimson"),
                new("Pink"),
                new("Cobalt"),
                new("Sky Blue"),
                new("Sienna"),
                new("Saffron"),
                new("Lime"),
                new("Green"),
                new("Orange"),
                new("Purple")
            };
            return list;

        }

        #endregion
    }
}