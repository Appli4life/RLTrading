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
        public ObservableCollection<Trade> AllTrades => TradeMocking.allTrades;

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
