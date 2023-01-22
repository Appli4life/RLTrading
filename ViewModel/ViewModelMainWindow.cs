

using System;
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
using RLTrading.View;

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
        public ObservableCollection<ContentControl> contents = new();

        /// <summary>
        /// AllTrade ContentControl
        /// </summary>
        private AllTrade allTrade = new();

        /// <summary>
        /// NewTrade ContentControl
        /// </summary>
        public NewTrade newTrade = new();

        /// <summary>
        /// DetailTrade ContentControl
        /// </summary>
        public DetailTrade detailTrade = new();

        /// <summary>
        /// Aktueller Content im ContentControl
        /// </summary>
        private ContentControl currentContent;
        private readonly ITradeRepository tradeRepository;

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
            SaveCommand = new RelayCommand(param => Execute_SaveTrade(), param => CanExecute_SaveTrade());

            contents.Add(allTrade);
            contents.Add(newTrade);
            contents.Add(detailTrade);

            Content = contents[0];
            this.tradeRepository = new JsonTradeRepository();
        }

        #endregion

        #region Methoden

        /// <summary>
        /// Execute SaveTrade
        /// </summary>
        public void Execute_SaveTrade()
        {
            var datacontext = (ViewModelNewTrade)newTrade.DataContext;
            var datacontextall = (ViewModelAllTrade)allTrade.DataContext;
            
            datacontext.EditTrade.Date = DateTime.Now;

            if (datacontextall.AllTrades.Contains(datacontext.EditTrade))
            {
                datacontextall.AllTrades.Remove(datacontext.EditTrade);
            }

            datacontextall.AllTrades.Add(datacontext.EditTrade);
            tradeRepository.SaveTrades(datacontextall.AllTrades);

            datacontext.EditTrade = new Trade();
            datacontext.SoldItems = new ObservableCollection<Item>();
            datacontext.GotItems = new ObservableCollection<Item>();
            datacontext.SoldItems.Add(new Item());
            datacontext.GotItems.Add(new Item());

            Content = contents[0];
        }

        /// <summary>
        /// Ob SaveTrad ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_SaveTrade()
        {
            if (currentContent == newTrade)
            {
                return true;
            }
            return false;
        }

        private void WantSave()
        {
            //if (Content == newTrade)
            //{
            //    if (MessageBoxResult.Yes == MessageBox.Show("Möchten Sie den Aktuellen Trade Speichern?\nDer Trade wird gelöscht, wenn Sie diesen gerade bearbeiten!", "Trade offen", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
            //    {
            //        Execute_SaveTrade();
            //    }
            //}
        }

        /// <summary>
        /// Close Command Execute
        /// </summary>
        private void Execute_Close()
        {
            WantSave();
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
            this.newTrade = new NewTrade();
            contents[1] = newTrade;
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
        //private void Execute_Save()
        //{
        //    if (TradeMocking.TradeSaver.saveTrades(TradeMocking.allTrades))
        //    {
        //        MessageBox.Show("Erfolgreich gespeichert", "Erfolg", MessageBoxButton.OK, MessageBoxImage.None);
        //    }
        //}

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
