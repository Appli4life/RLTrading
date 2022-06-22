using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public int gotCredits { get; set; } = 0;

        /// <summary>
        /// Alle verlorenen Credits
        /// </summary>
        public int lostCredits { get; set; } = 0;

        /// <summary>
        /// Alle verkauften Items
        /// </summary>
        public ObservableCollection<Item> soldItems = new();


        /// <summary>
        /// Alle gekauften Items
        /// </summary>
        public ObservableCollection<Item> boughtItems = new();

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
