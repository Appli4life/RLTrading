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
        public static readonly List<Quality> Qualities = new()
        {
                new Quality("Common", System.Windows.Media.Color.FromRgb(136, 136, 136)),
                new Quality("Uncommon", System.Windows.Media.Color.FromRgb(135, 206, 235)),
                new Quality("Rare", System.Windows.Media.Color.FromRgb(0,0,250)),
                new Quality("Very Rare", System.Windows.Media.Color.FromRgb(186,85,211)),
                new Quality("Import", System.Windows.Media.Color.FromRgb(255,42,4)),
                new Quality("Exotic", System.Windows.Media.Color.FromRgb(255,215,0)),
                new Quality("Black Market", System.Windows.Media.Color.FromRgb(242,20,214)),
        };

        #endregion
    }
}

