using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLTrading.Model;

namespace RLTrading.ViewModel
{
    public class ViewModelDetailTrade : ViewModelBase
    {
        #region Property

        /// <summary>
        /// Der Trades
        /// </summary>
        private Trade trade = new Trade();

        /// <summary>
        /// Accsessor für Trade
        /// </summary>
        public Trade Trade
        {
            get => trade;
            set => SetProperty(ref trade, value);
        }

        /// <summary>
        /// Accessor für alle Verkauften Items
        /// </summary>
        public ObservableCollection<Item> SoldItems
        {
            get => Trade.soldItems;
            set => SetProperty(ref Trade.soldItems, value);
        }

        /// <summary>
        /// Accessor für alle Gekauften Items
        /// </summary>
        public ObservableCollection<Item> GotItems
        {
            get => Trade.boughtItems;
            set => SetProperty(ref Trade.boughtItems, value);
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelDetailTrade()
        {

        }

        #endregion
    }
}
