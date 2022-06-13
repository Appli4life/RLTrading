using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
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
                new Quality("Common", Brushes.Gray),
                new Quality("Uncommon", Brushes.LightBlue),
                new Quality("Rare", Brushes.Blue),
                new Quality("Very Rare", Brushes.Purple),
                new Quality("Import", Brushes.Red),
                new Quality("Exotic", Brushes.Gold),
                new Quality("Black Market", Brushes.DeepPink),
        };

        #endregion
    }
}

