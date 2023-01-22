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
            this.Name = name;
            this.Brush = brush;
        }

        #endregion
    }
}
