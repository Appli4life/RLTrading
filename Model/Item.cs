using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLTrading.Model;


namespace RLTrading.Model
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
        public bool Blueprint { get; set; } = false;

        /// <summary>
        /// Anzahl
        /// </summary>
        public int count { get; set; } = 1;

        /// <summary>
        /// Anzahlt der Items Accessor
        /// </summary>
        public int Count
        {
            get => count;
            set
            {
                if (Count > 0)
                {
                    count = value;
                }
            }
        }      

        /// <summary>
        /// Name des Item
        /// </summary>
        private string name = "Fennec";

        /// <summary>
        /// Accsessor Name
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// Farbe des Item
        /// </summary>
        private Color color = ColorMocking.Colors[0];

        /// <summary>
        /// Accsessor der Farbe
        /// </summary>
        public Color Color
        {
            get => color;
            set => color = value;
        }

        /// <summary>
        /// Zertifizierung des Item
        /// </summary>
        private Certification certification = CertificationMocking.Certifications[0];

        /// <summary>
        /// Accsessor der Zertifizierung 
        /// </summary>
        public Certification Certification
        {
            get => certification;
            set => certification = value;
        }

        /// <summary>
        /// Qualität des Item
        /// </summary>
        private Quality quality = QualityMocking.Qualities[0];

        /// <summary>
        /// Accsessor der Qualität 
        /// </summary>
        public Quality Quality
        {
            get => quality;
            set => quality = value;
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
        /// <param name="count">Anzahl</param>
        public Item(string name, Color color, Certification certification, Quality quality, int count, bool blueprint = false)
        {
            Name = name;
            Color = color;
            Certification = certification;
            Quality = quality;
            Blueprint = blueprint;
            Count = count;
        }

        #endregion
    }
}
