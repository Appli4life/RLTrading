using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Zertifizierung Mocking
    /// </summary>
    public static class CertificationMocking
    {
        #region Property

        /// <summary>
        /// Liste mit Zertifizierungen
        /// </summary>
        public static List<Certification> Certifications = new()
            {
                new Certification("None"),
                new Certification("Striker"),
                new Certification("Sweeper"),
                new Certification("Tactician"),
                new Certification("Acrobat"),
                new Certification("Aviator"),
                new Certification("Goalkeeper"),
                new Certification("Guardian"),
                new Certification("Juggler"),
                new Certification("Playmaker"),
                new Certification("Scorer"),
                new Certification("Show-Off"),
                new Certification("Sniper"),
                new Certification("Turle"),
                new Certification("Paragon"),
                new Certification("Victor")
            };

        #endregion
    }
}
