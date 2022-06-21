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

        /// <summary>
        /// Selected Trade in datagrid
        /// </summary>
        private Trade selectedTrade;


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
            DetailTrade = new RelayCommand(param => Execute_DetailTrade(), param => CanExecute_DetailTrade());
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
            data.Trade = SelectedTrade;
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

        #endregion

    }
}
