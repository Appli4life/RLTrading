using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace RLTrading.Model
{
    /// <summary>
    /// Qualität Mocking
    /// </summary>
    public static class QualityMocking
    {
        #region Methoden

        /// <summary>
        /// Holt Liste von Qualitäten
        /// </summary>
        /// <returns>Liste mit Qualitäten (neu erstellt)</returns>
        public static List<Quality> GetQualities()
        {
            List<Quality> list = new List<Quality>
            {
                new("Common"),
                new("Uncommon"),
                new("Rare"),
                new("Very Rare"),
                new("Import"),
                new("Exotic"),
                new("Black Market"),
                new("Premium"),
                new("Limited"),
                new("Legacy")
            };
            return list;

        }

        #endregion
    }
}

