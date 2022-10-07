using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Interface für Speicherung der Trades
    /// </summary>
    public interface ISaver
    {
        #region Methoden

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
        Task<bool> saveTradesAsync(ObservableCollection<Trade> allTrades);

        #endregion
    }
}
