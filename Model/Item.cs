using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLTrading.Model;


namespace RLTrading
{
    /// <summary>
    /// Item Model
    /// </summary>
    public class Item
    {
        #region Property

        /// <summary>
        /// True = Blueprint / False = Kein Blueprint
        /// </summary>
        public bool Blueprint { get; set; }

        /// <summary>
        /// Name des Item
        /// </summary>
        private string name;

        /// <summary>
        /// Accsessor Name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Farbe des Item
        /// </summary>
        private Color color;

        /// <summary>
        /// Accsessor der Farbe
        /// </summary>
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Zertifizierung des Item
        /// </summary>
        private Certification certification;

        /// <summary>
        /// Accsessor der Zertifizierung 
        /// </summary>
        public Certification Certification
        {
            get { return certification; }
            set { certification = value; }
        }

        /// <summary>
        /// Qualität des Item
        /// </summary>
        private Quality quality;

        /// <summary>
        /// Accsessor der Qualität 
        /// </summary>
        public Quality Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        #endregion

        #region Ctor
        /// <summary>
        /// Ctor
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="color">Farbe</param>
        /// <param name="certification">Zertifizierung</param>
        /// <param name="quality">Qualität</param>
        /// <param name="blueprint">Blueprint Y/N</param>
        public Item(string name, Color color, Certification certification, Quality quality, bool blueprint = false)
        {
            Name = name;
            Color = color;
            Certification = certification;
            Quality = quality;
            Blueprint = blueprint;
        }

        #endregion
    }
}
