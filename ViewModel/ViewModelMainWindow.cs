

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mime;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using RLTrading.ViewModel;
using RLTrading.Model;
using RLTrading.Utility;

namespace RLTrading.ViewModel
{
    /// <summary>
    /// ViewModel für MainWindow
    /// </summary>
    public class ViewModelMainWindow : ViewModelBase
    {
        #region Property

        /// <summary>
        /// Close Command
        /// </summary>
        public RelayCommand CloseApp { get; set; }

        /// <summary>
        /// AllTrade Command
        /// </summary>
        public RelayCommand AllTradeSwitch { get; set; }

        /// <summary>
        /// NewTrade Command
        /// </summary>
        public RelayCommand NewTradeSwitch { get; set; }

        /// <summary>
        /// Save Command
        /// </summary>
        public RelayCommand SaveCommand { get; set; }

        /// <summary>
        /// Collection von allen ContentControls
        /// </summary>
        private ObservableCollection<ContentControl> contents = new();

        /// <summary>
        /// AllTrade ContentControl
        /// </summary>
        private AllTrade allTrade = new();

        /// <summary>
        /// NewTrade ContentControl
        /// </summary>
        private NewTrade newTrade = new();

        /// <summary>
        /// Aktueller Content im ContentControl
        /// </summary>
        private ContentControl currentContent;

        /// <summary>
        /// Accessor für Aktueller ContentControl
        /// </summary>
        public ContentControl Content
        {
            get => currentContent;
            set => SetProperty(ref currentContent, value);
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelMainWindow()
        {
            CloseApp = new RelayCommand(param => Execute_Close(), param => canExecute_Close());
            AllTradeSwitch = new RelayCommand(param => Execute_AllTrade(), param => canExecute_AllTrade());
            NewTradeSwitch = new RelayCommand(param => Execute_NewTrade(), param => canExecute_NewTrade());
            SaveCommand = new RelayCommand(param => Execute_Save(), param => canExecute_Save());

            contents.Add(allTrade);
            contents.Add(newTrade);

            currentContent = contents[0];
        }

        #endregion

        #region Command Methoden

        /// <summary>
        /// Close Command Execute
        /// </summary>
        private void Execute_Close()
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Close Command canExecute
        /// </summary>
        /// <returns>True / False</returns>
        private bool canExecute_Close()
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// AllTrade Command Execute
        /// </summary>
        private void Execute_AllTrade()
        {
            Content = contents[0];
        }

        /// <summary>
        /// AllTrade Command can Execute
        /// </summary>
        /// <returns>True / False</returns>
        private bool canExecute_AllTrade()
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// NewTrade Command Execute
        /// </summary>
        private void Execute_NewTrade()
        {
            Content = contents[1];
        }

        /// <summary>
        /// NewTrade Command can Execute
        /// </summary>
        /// <returns>True / False</returns>
        private bool canExecute_NewTrade()
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Save Command Execute
        /// </summary>
        private void Execute_Save()
        {
            TradeMocking.TradeSaver.saveTrades(TradeMocking.allTrades);
            MessageBox.Show("Erfolgreich gespeichert", "Erfolg", MessageBoxButton.OK, MessageBoxImage.None);
        }

        /// <summary>
        /// Save Command can Execute
        /// </summary>
        /// <returns>True / False</returns>
        private bool canExecute_Save()
        {
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
