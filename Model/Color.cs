using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RLTrading.Model
{
    /// <summary>
    /// Color Model
    /// </summary>
    public class Color
    {
        #region Property

        /// <summary>
        /// Name der Farbe
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Farbe zum Namen
        /// </summary>
        public SolidColorBrush Brush { get; private set; }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public Color()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        public Color(string name, SolidColorBrush brush)
        {
            Name = name;
            Brush = brush;
        }

        #endregion
    }
}
