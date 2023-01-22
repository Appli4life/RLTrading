using System.Collections.Generic;

namespace RLTrading.Model
{
    /// <summary>
    /// Qualität Mocking
    /// </summary>
    public static class QualityMocking
    {
        private static List<Quality> qualities;

        public static List<Quality> GetQuality()
        {
            if (qualities is null)
            {
                qualities = new()
                {
                   new Quality("Common", System.Windows.Media.Color.FromRgb(136, 136, 136)),
                    new Quality("Uncommon", System.Windows.Media.Color.FromRgb(135, 206, 235)),
                    new Quality("Rare", System.Windows.Media.Color.FromRgb(0,0,250)),
                    new Quality("Very Rare", System.Windows.Media.Color.FromRgb(186,85,211)),
                    new Quality("Import", System.Windows.Media.Color.FromRgb(255,42,4)),
                    new Quality("Exotic", System.Windows.Media.Color.FromRgb(255,215,0)),
                    new Quality("Black Market", System.Windows.Media.Color.FromRgb(242,20,214)),
                };
            }
            return qualities;
        }

    }
}

