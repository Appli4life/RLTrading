using System.Collections.ObjectModel;
using System.Windows;
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

        public ObservableCollection<Color> AllBrushes => new(ColorMocking.Colors);

        /// <summary>
        /// Selected Trade in datagrid
        /// </summary>
        private Trade selectedTrade;

        /// <summary>
        /// Das zu suchende Item
        /// </summary>
        private Item searchItem;
        private TradeMocking tradeMocking;

        /// <summary>
        /// Accessor für Suchendes Item
        /// </summary>
        public Item SearchItem
        {
            get => this.searchItem;
            set => this.SetProperty(ref this.searchItem, value);
        }

        /// <summary>
        /// Accessor für Selected Trade
        /// </summary>
        public Trade SelectedTrade
        {
            get => this.selectedTrade;
            set => this.SetProperty(ref this.selectedTrade, value);
        }

        /// <summary>
        /// Detail Trade Command
        /// </summary>
        public RelayCommand DetailTrade { get; set; }

        /// <summary>
        /// Search Item Command
        /// </summary>
        public RelayCommand SearchItemBtn { get; set; }

        /// <summary>
        /// Search zurücksetzen Command
        /// </summary>
        public RelayCommand SearchClear { get; set; }

        /// <summary>
        /// Accessor für alle Trade Collection
        /// </summary>
        public ObservableCollection<Trade> AllTrades => this.tradeMocking.allTrades;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelAllTrade()
        {
            this.DetailTrade = new RelayCommand(param => this.Execute_DetailTrade(), param => this.CanExecute_DetailTrade());
            this.SearchItemBtn = new RelayCommand(param => this.Execute_SearchItem(), param => this.CanExecute_SearchItem());
            this.SearchClear = new RelayCommand(param => this.Execute_SearchClear(), param => this.CanExecute_SearchClear());
            this.AllBrushes.Add(new Color("Any", null));
            this.tradeMocking = new TradeMocking();
        }

        #endregion

        #region Command Methoden

        /// <summary>
        /// Detail Trade Command Execute
        /// </summary>
        private void Execute_DetailTrade()
        {
            var dataContext = (ViewModelMainWindow)Application.Current.MainWindow.DataContext;
            var data = (ViewModelDetailTrade)dataContext.detailTrade.DataContext;
            dataContext.Content = dataContext.contents[2];
            data.Trade = this.SelectedTrade;
            data.GotItems = new ObservableCollection<Item>(this.SelectedTrade.boughtItems);
            data.SoldItems = new ObservableCollection<Item>(this.SelectedTrade.soldItems);
        }

        /// <summary>
        /// Ob Detail Trade ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_DetailTrade()
        {
            if (this.SelectedTrade != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Search Item Command Execute
        /// </summary>
        private void Execute_SearchItem()
        {
            // Trades speichern
            //TradeMocking.TradeSaver.saveTrades(TradeMocking.allTrades);

            //AllTrades.Clear();

            //var result = TradeMocking.allTrades.Where(trade => trade.soldItems.Where(item => item.Name == searchItem.Name)) as ObservableCollection<Trade>;


        }

        /// <summary>
        /// Ob Search Item ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_SearchItem()
        {
            if (true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Search zurücksetzen Command Execute
        /// </summary>
        private void Execute_SearchClear()
        {

        }

        /// <summary>
        /// Ob search zurücksetzen ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_SearchClear()
        {
            if (true)
            {
                return true;
            }
            return false;
        }

        #endregion

    }
}
