using System;
using Newtonsoft.Json;

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
        private int count { get; set; } = 1;

        /// <summary>
        /// Anzahlt der Items Accessor
        /// </summary>
        public int Count
        {
            get => count;
            set
            {
                if (value > 0)
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
        private Color color;

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
        private Certification certification = CertificationMocking.getCertifications()[0];

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
        private Quality quality = QualityMocking.getQuality()[4];

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

        #endregion
    }

}
