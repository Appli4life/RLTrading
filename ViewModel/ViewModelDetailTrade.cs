using System.Collections.ObjectModel;
using RLTrading.Model;

namespace RLTrading.ViewModel
{
    public class ViewModelDetailTrade : ViewModelBase
    {
        #region Property

        /// <summary>
        /// Der Trades
        /// </summary>
        private Trade trade = new();

        /// <summary>
        /// Accsessor für Trade
        /// </summary>
        public Trade Trade
        {
            get => this.trade;
            set => this.SetProperty(ref this.trade, value);
        }

        /// <summary>
        /// Accessor für alle Verkauften Items
        /// </summary>
        public ObservableCollection<Item> SoldItems
        {
            get => this.Trade.SoldItems;
            set => this.SetProperty(ref this.Trade.SoldItems, value);
        }

        /// <summary>
        /// Accessor für alle Gekauften Items
        /// </summary>
        public ObservableCollection<Item> GotItems
        {
            get => this.Trade.BoughtItems;
            set => this.SetProperty(ref this.Trade.BoughtItems, value);
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

        #region Command Methoden

        #endregion
    }
}
