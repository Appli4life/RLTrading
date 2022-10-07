namespace RLTrading.Model
{
    /// <summary>
    /// Zertifizierung Model
    /// </summary>
    public class Certification
    {
        #region Property

        /// <summary>
        /// Name der Zertifizierung
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public Certification()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        public Certification(string name)
        {
            this.Name = name;
        }

        #endregion
    }
}
