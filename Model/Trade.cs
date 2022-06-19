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
        public ObservableCollection<Item> soldItems = new ObservableCollection<Item>();


        /// <summary>
        /// Alle gekauften Items
        /// </summary>
        public ObservableCollection<Item> boughtItems = new ObservableCollection<Item>();

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public Trade()
        {
            
        }

        /// <summary>
        /// Clone erstellen
        /// </summary>
        /// <returns>Eine Kopie von dem aktuellen Trade</returns>
        public Trade Clone()
        {
            var json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Trade>(json);
        }

        #endregion
    }
}
