using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    public interface ITradeRepository
    {
        ObservableCollection<Trade> loadTrades();

        bool SaveTrades(IEnumerable<Trade> trades);
    }
}
