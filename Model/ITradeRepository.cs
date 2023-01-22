using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RLTrading.Model
{
    public interface ITradeRepository
    {
        ObservableCollection<Trade> LoadTrades();

        bool SaveTrades(IEnumerable<Trade> trades);
    }
}
