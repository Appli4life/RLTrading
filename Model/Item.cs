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
            get => this.count;
            set
            {
                if (value > 0)
                {
                    this.count = value;
                }
            }
        }

        /// <summary>
        /// Accsessor Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Accsessor der Farbe
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Accsessor der Zertifizierung 
        /// </summary>
        public Certification Certification { get; set; } = CertificationMocking.GetCertifications()[0];

        /// <summary>
        /// Accsessor der Qualität 
        /// </summary>
        public Quality Quality { get; set; } = QualityMocking.GetQuality()[4];

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
