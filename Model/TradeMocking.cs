using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Klasse zur Statischen Speicherung aller Trades
    /// </summary>
    public class TradeMocking
    {
        public TradeMocking()
        {
            this.TradeSaver = new JsonSaver();
            this.allTrades = this.TradeSaver.loadTrades();
        }

        #region Property

        /// <summary>
        /// Neuer JsonSaver
        /// </summary>
        public ISaver TradeSaver;

        /// <summary>
        /// Neue Collection mit allen Trades
        /// </summary>
        public ObservableCollection<Trade> allTrades;

        public async Task<bool> SaveTrades()
        {
            return await this.TradeSaver.saveTradesAsync(this.allTrades);
        }

        #endregion
    }
}
