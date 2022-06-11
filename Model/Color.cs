using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Color Model
    /// </summary>
    public class Color
    {
        /// <summary>
        /// Name der Farbe
        /// </summary>
        public string Name { get; set; }

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
        public Color(string name)
        {
            Name = name;
        }
    }
}
