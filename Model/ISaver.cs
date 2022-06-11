using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Interface für Speicherung der Trades
    /// </summary>
    public interface ISaver
    {
        /// <summary>
        /// Laden aller Trades
        /// </summary>
        /// <returns>ObservableCollection mit Trades</returns>
        ObservableCollection<Trade> loadTrades();

        /// <summary>
        /// Speicherung aller Trades
        /// </summary>
        /// <param name="allTrades">Die zu speichernde Trades</param>
        /// <returns>True / False je nach erfolg</returns>
        bool saveTrades(ObservableCollection<Trade> allTrades);
    }
}
