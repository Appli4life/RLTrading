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
        /// <summary>
        /// Holt Liste von Qualitäten
        /// </summary>
        /// <returns>Liste mit Qualitäten (neu erstellt)</returns>
        public static List<Quality> GetQualities()
        {
            List<Quality> list = new List<Quality>
            {
                new Quality("Common"),
                new Quality("Uncommon"),
                new Quality("Rare"),
                new Quality("Very Rare"),
                new Quality("Import"),
                new Quality("Exotic"),
                new Quality("Black Market"),
                new Quality("Premium"),
                new Quality("Limited"),
                new Quality("Legacy")
            };
            return list;

        }
    }
}

