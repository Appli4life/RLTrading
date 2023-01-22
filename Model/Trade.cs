using System;
using System.Collections.ObjectModel;

namespace RLTrading.Model
{
    /// <summary>
    /// Trade Model
    /// </summary>
    public class Trade
    {
        #region Property

        /// <summary>
        /// Name für den Trade
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Epic Name der Person mit der man den Trade gemacht hat
        /// </summary>
        public string Trader { get; set; }

        /// <summary>
        /// Datum des Trade
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Alle erhaltenen Credits
        /// </summary>
        public int GotCredits { get; set; } = 0;

        /// <summary>
        /// Alle verlorenen Credits
        /// </summary>
        public int LostCredits { get; set; } = 0;

        /// <summary>
        /// Alle verkauften Items
        /// </summary>
        public ObservableCollection<Item> SoldItems = new();


        /// <summary>
        /// Alle gekauften Items
        /// </summary>
        public ObservableCollection<Item> BoughtItems = new();

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public Trade()
        {

        }

        #endregion
    }
}
