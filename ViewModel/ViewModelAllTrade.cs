using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RLTrading.ViewModel;
using RLTrading.Model;
using RLTrading.Utility;
using RLTrading.View;

namespace RLTrading.ViewModel
{
    /// <summary>
    /// ViewModel für UserControl: AllTrade
    /// </summary>
    public class ViewModelAllTrade : ViewModelBase
    {
        #region Property

        public IEnumerable<Color> AllBrushes => ColorMocking.getColors();

        /// <summary>
        /// Selected Trade in datagrid
        /// </summary>
        private Trade selectedTrade;

        /// <summary>
        /// Das zu suchende Item
        /// </summary>
        private Item searchItem;

        private readonly ITradeRepository tradeRepository;

        /// <summary>
        /// Accessor für Suchendes Item
        /// </summary>
        public Item SearchItem
        {
            get => searchItem;
            set => SetProperty(ref searchItem, value);
        }

        /// <summary>
        /// Accessor für Selected Trade
        /// </summary>
        public Trade SelectedTrade
        {
            get => selectedTrade;
            set => SetProperty(ref selectedTrade, value);
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
        /// Alle Trade Collection
        /// </summary>
        public ObservableCollection<Trade> AllTrades { get; set; }


        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelAllTrade()
        {
            DetailTrade = new RelayCommand(param => Execute_DetailTrade(), param => CanExecute_DetailTrade());
            SearchItemBtn = new RelayCommand(param => Execute_SearchItem(), param => CanExecute_SearchItem());
            SearchClear = new RelayCommand(param => Execute_SearchClear(), param => CanExecute_SearchClear());
            tradeRepository = new JsonTradeRepository();
            AllTrades = tradeRepository.loadTrades();
        }

        #endregion

        public void OnDelete()
        {
            AllTrades.Remove(SelectedTrade);
            tradeRepository.SaveTrades(AllTrades);
        }

        public void OnEdit()
        {
            var mainDatacontext = (ViewModelMainWindow)Application.Current.MainWindow.DataContext;
            mainDatacontext.Content = mainDatacontext.contents[1];
            var newTradeDataContext = (ViewModelNewTrade)mainDatacontext.newTrade.DataContext;

            newTradeDataContext.EditTrade = SelectedTrade;
            newTradeDataContext.SoldItems = new(SelectedTrade.soldItems);
            newTradeDataContext.GotItems = new(SelectedTrade.boughtItems);
        }



        #region Command Methoden

        /// <summary>
        /// Detail Trade Command Execute
        /// </summary>
        private void Execute_DetailTrade()
        {
            var dataContext = (ViewModelMainWindow)Application.Current.MainWindow.DataContext;
            var data = (ViewModelDetailTrade)dataContext.detailTrade.DataContext;
            dataContext.Content = dataContext.contents[2];
            data.Trade = SelectedTrade;
            data.GotItems = new ObservableCollection<Item>(SelectedTrade.boughtItems);
            data.SoldItems = new ObservableCollection<Item>(SelectedTrade.soldItems);
        }

        /// <summary>
        /// Ob Detail Trade ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_DetailTrade()
        {
            if (SelectedTrade != null)
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
