using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using RLTrading.Model;
using RLTrading.Utility;
using RLTrading.View;
using RLTrading.ViewModel;

namespace RLTrading.ViewModel
{
    /// <summary>
    /// ViewModel für UserControl: NewTrade
    /// </summary>
    public class ViewModelNewTrade : ViewModelBase
    {
        #region ContentControls

        /// <summary>
        /// Collection von gegeben ContentControls
        /// </summary>
        public ObservableCollection<ContentControl> gegebenContents = new();

        /// <summary>
        /// Aktueller gegeben Content
        /// </summary>
        private ContentControl CurrentGegebenContent;

        /// <summary>
        /// Collection von bekommen ContentControls
        /// </summary>
        public ObservableCollection<ContentControl> bekommenContents = new();

        /// <summary>
        /// Aktueller bekommen Content
        /// </summary>
        private ContentControl CurrentBekommenContent;

        /// <summary>
        /// ContentControl für alle gegebenen Items
        /// </summary>
        private GegebenAlleItems gegebenAlle = new();

        /// <summary>
        /// ContentControl für neue gegebenes Item
        /// </summary>
        private GegebenNeuesItem gegebenNeues = new();

        /// <summary>
        /// ContentControl für alle bekommenen Items
        /// </summary>
        private BekommenAlleItems bekommenAlle = new();

        /// <summary>
        /// ContentControl für neu bekommenes Item
        /// </summary>
        private BekommenNeuesItem bekommenNeues = new();

        /// <summary>
        /// Accessor für Current gegeben Content
        /// </summary>
        public ContentControl CurrentGContent
        {
            get => CurrentGegebenContent;
            set => SetProperty(ref CurrentGegebenContent, value);
        }

        /// <summary>
        /// Accessor für Current bekommen Content
        /// </summary>
        public ContentControl CurrentBContent
        {
            get => CurrentBekommenContent;
            set => SetProperty(ref CurrentBekommenContent, value);
        }

        #endregion

        #region Property

        /// <summary>
        /// Trade der hinzugefügt wird
        /// </summary>
        private Trade currentTrade = new();


        /// <summary>
        /// Accessor für neuer Trade
        /// </summary>
        public Trade EditTrade
        {
            get => currentTrade;
            set => SetProperty(ref currentTrade, value);
        }

        /// <summary>
        /// Save Trade Command
        /// </summary>
        public RelayCommand SaveTrade { get; set; }

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelNewTrade()
        {
            SaveTrade = new RelayCommand(param => Execute_SaveTrade(), param => CanExecute_SaveTrade());

            gegebenContents.Add(gegebenAlle);
            gegebenContents.Add(gegebenNeues);
            
            bekommenContents.Add(bekommenAlle);
            bekommenContents.Add(bekommenNeues);

            CurrentGegebenContent = gegebenContents[0];
            CurrentBekommenContent = bekommenContents[0];
        }

        #endregion

        #region Commands

        public void Execute_SaveTrade()
        {
            TradeMocking.allTrades.Add(currentTrade);
            EditTrade = new Trade();
            
        }

        /// <summary>
        /// Ob SaveTrad ausgeführt werden kann
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_SaveTrade()
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
