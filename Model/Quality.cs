using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RLTrading.Model
{
    /// <summary>
    /// Model Qualität
    /// </summary>
    public class Quality
    {
        #region Property

        /// <summary>
        /// Name der Qualität
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Farbe
        /// </summary>
        public SolidColorBrush Brush { get; set; }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public Quality()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        public Quality(string name, SolidColorBrush brush)
        {
            Brush = brush;
            Name = name;
        }

        #endregion
    }
}
