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
        /// <summary>
        /// Holt Liste von Farben
        /// </summary>
        /// <returns>Liste mit Farben (neu erstellt)</returns>
        public static List<Color> GetQualities()
        {
            List<Color> list = new List<Color>
            {
                new Color("Default"),
                new Color("Black"),
                new Color("White"),
                new Color("Grey"),
                new Color("Crimson"),
                new Color("Pink"),
                new Color("Cobalt"),
                new Color("Sky Blue"),
                new Color("Sienna"),
                new Color("Saffron"),
                new Color("Lime"),
                new Color("Green"),
                new Color("Orange"),
                new Color("Purple")
            };
            return list;

        }
    }
}