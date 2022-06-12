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
        #region Property

        /// <summary>
        /// Liste von Qualitäten
        /// </summary>
        public static List<Quality> Qualities = new()
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

        #endregion
    }
}

