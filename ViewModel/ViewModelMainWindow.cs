

using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
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

        private TradeMocking tradeMocking;
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

        /// <summary>
        /// Accessor für Aktueller ContentControl
        /// </summary>
        public ContentControl Content
        {
            get => this.currentContent;
            set => this.SetProperty(ref this.currentContent, value);
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelMainWindow()
        {
            this.tradeMocking = new TradeMocking();

            this.CloseApp = new RelayCommand(param => this.Execute_Close(), param => this.canExecute_Close());
            this.AllTradeSwitch = new RelayCommand(param => this.Execute_AllTrade(), param => this.canExecute_AllTrade());
            this.NewTradeSwitch = new RelayCommand(param => this.Execute_NewTrade(), param => this.canExecute_NewTrade());
            this.SaveCommand = new RelayCommand(param => this.Execute_SaveTrade(), param => this.CanExecute_SaveTrade());

            this.contents.Add(this.allTrade);
            this.contents.Add(this.newTrade);
            this.contents.Add(this.detailTrade);

            this.Content = this.contents[0];
        }

        #endregion

        #region Methoden

        /// <summary>
        /// Execute SaveTrade
        /// </summary>
        public async void Execute_SaveTrade()
        {
            var datacontext = (ViewModelNewTrade)this.newTrade.DataContext;
            datacontext.EditTrade.Date = DateTime.Now;
            this.tradeMocking.allTrades.Add(datacontext.EditTrade);
            await this.tradeMocking.SaveTrades();

            datacontext.EditTrade = new Trade();
            datacontext.SoldItems = new ObservableCollection<Item>();
            datacontext.GotItems = new ObservableCollection<Item>();
            datacontext.SoldItems.Add(new Item());
            datacontext.GotItems.Add(new Item());

            this.Content = this.contents[0];

        }

        /// <summary>
        /// Ob SaveTrad ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_SaveTrade()
        {
            if (this.currentContent == this.newTrade)
            {
                return true;
            }
            return false;
        }

        private void WantSave()
        {
            if (this.Content == this.newTrade)
            {
                if (MessageBoxResult.Yes == MessageBox.Show("Möchten Sie den Aktuellen Trade Speichern?\nDer Trade wird gelöscht, wenn Sie diesen gerade bearbeiten!", "Trade offen", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
                {
                    this.Execute_SaveTrade();
                }
            }
        }

        /// <summary>
        /// Close Command Execute
        /// </summary>
        private void Execute_Close()
        {
            this.WantSave();
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
            this.WantSave();
            this.Content = this.contents[0];
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
            this.Content = this.contents[1];
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
        private async void Execute_Save()
        {
            if (await this.tradeMocking.SaveTrades())
            {
                MessageBox.Show("Erfolgreich gespeichert", "Erfolg", MessageBoxButton.OK, MessageBoxImage.None);
            }
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
