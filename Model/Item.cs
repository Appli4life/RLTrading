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
        public bool Blueprint { get; set; }

        /// <summary>
        /// Anzahl
        /// </summary>
        private int count { get; set; }

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
        public Certification Certification { get; set; }

        /// <summary>
        /// Accsessor der Qualität 
        /// </summary>
        public Quality Quality { get; set; }

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
            this.Name = name;
            this.Color = color;
            this.Certification = certification;
            this.Quality = quality;
            this.Blueprint = blueprint;
            this.Count = count;
        }

        #endregion
    }
}
