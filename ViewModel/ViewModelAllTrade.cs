using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLTrading.ViewModel;
using RLTrading.Model;
using RLTrading.Utility;

namespace RLTrading.ViewModel
{
    /// <summary>
    /// ViewModel für UserControl: AllTrade
    /// </summary>
    public class ViewModelAllTrade : ViewModelBase
    {
        #region Property
        
        /// <summary>
        /// Accessor für alle Trade Collection
        /// </summary>
        public ObservableCollection<Trade> AllTrades
        {
            //erkennt jetzt änderungen wie add und remove 
            // Seperates edit feld einfügen, (Der trade der gerade editiert wird binden mit dem trade in der liste und der anzeige)
            get => TradeMocking.allTrades;
            set => TradeMocking.allTrades = value;
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelAllTrade()
        {
            
        }

        #endregion

    }
}
