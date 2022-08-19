using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Klasse zur Statischen Speicherung aller Trades
    /// </summary>
    public static class TradeMocking
    {
        #region Property

        /// <summary>
        /// Neuer JsonSaver
        /// </summary>
        public static ISaver TradeSaver = new JsonSaver();

        /// <summary>
        /// Neue Collection mit allen Trades
        /// </summary>
        public static ObservableCollection<Trade> allTrades = TradeSaver.loadTrades();
        
        #endregion
    }
}
