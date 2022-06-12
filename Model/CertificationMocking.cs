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
        #region Methoden

        /// <summary>
        /// Holt Liste von Zertifizierungen
        /// </summary>
        /// <returns>Liste mit Zertifizierungen (neu erstellt)</returns>
        public static List<Certification> GetCertifications()
        {
            List<Certification> list = new List<Certification>()
            {
                new("None"),
                new("Striker"),
                new("Sweeper"),
                new("Tactician"),
                new("Acrobat"),
                new("Aviator"),
                new("Goalkeeper"),
                new("Guardian"),
                new("Juggler"),
                new("Playmaker"),
                new("Scorer"),
                new("Show-Off"),
                new("Sniper"),
                new("Turle"),
                new("Paragon"),
                new("Victor")
            };
            return list;
        }

        #endregion
    }
}
