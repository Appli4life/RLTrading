using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using RLTrading.Model;
using RLTrading.Utility;
using RLTrading.View;
using RLTrading.ViewModel;
using Color = RLTrading.Model.Color;

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
        private GegebenEditItem gegebenEdit = new();

        /// <summary>
        /// ContentControl für alle bekommenen Items
        /// </summary>
        private BekommenAlleItems bekommenAlle = new();

        /// <summary>
        /// ContentControl für neu bekommenes Item
        /// </summary>
        private BekommenEditItem bekommenEdit = new();

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
        /// Alle Farben für Items
        /// </summary>
        public ObservableCollection<Color> AllBrushes => new(ColorMocking.Colors);

        /// <summary>
        /// Alle Zertifizierungen für Items
        /// </summary>
        public ObservableCollection<Certification> AllCertifications => new(CertificationMocking.Certifications);

        /// <summary>
        /// Alle Qualitäten für Items
        /// </summary>
        public ObservableCollection<Quality> AllQualities => new(QualityMocking.Qualities);

        /// <summary>
        /// Accessor für neuer Trade
        /// </summary>
        public Trade EditTrade
        {
            get => currentTrade;
            set => SetProperty(ref currentTrade, value);
        }

        /// <summary>
        /// Accessor für alle Verkauften Items
        /// </summary>
        public ObservableCollection<Item> SoldItems
        {
            get => EditTrade.soldItems;
            set => SetProperty(ref EditTrade.soldItems, value);
        }

        /// <summary>
        /// Accessor für alle Gekauften Items
        /// </summary>
        public ObservableCollection<Item> GotItems
        {
            get => EditTrade.boughtItems;
            set => SetProperty(ref EditTrade.boughtItems, value);
        }

        /// <summary>
        /// Gegeben Item Hinzufügen
        /// </summary>
        public RelayCommand soldItemAdd { get; set; }

        /// <summary>
        /// Bekommen Item Hinzufügen
        /// </summary>
        public RelayCommand gotItemAdd { get; set; }

        /// <summary>
        /// Item Löschen
        /// </summary>
        public RelayCommand ItemDelete { get; set; }

        /// <summary>
        /// Selected item in Listbox ( für beide )
        /// </summary>
        private Item selectedItem;

        /// <summary>
        /// Aktuelles Editierts gegeben Item
        /// </summary>
        private Item editedGItem;

        /// <summary>
        /// Aktuelles Editierts gegeben Item
        /// </summary>
        private Item editedBItem;

        /// <summary>
        /// Accessor für Selected Item
        /// </summary>
        public Item SelectedItem
        {
            get => selectedItem;
            set => SetProperty(ref selectedItem, value);
        }

        /// <summary>
        /// Accessor für GEditItem
        /// </summary>
        public Item GEditItem
        {
            get => editedGItem;
            set => SetProperty(ref editedGItem, value);
        }

        /// <summary>
        /// Accessor für BEditItem
        /// </summary>
        public Item BEditItem
        {
            get => editedBItem;
            set => SetProperty(ref editedBItem, value);
        }

        /// <summary>
        /// Item Editieren Anwenden Bekommen
        /// </summary>
        public RelayCommand AnwendenB { get; set; }

        /// <summary>
        /// Item Editieren Anwenden Gegeben
        /// </summary>
        public RelayCommand AnwendenG { get; set; }


        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelNewTrade()
        {
            SoldItems.Add(new Item());
            GotItems.Add(new Item());

            AnwendenB = new RelayCommand(param => Execute_AnwendenB(), param => CanExecute_AnwendenB());
            AnwendenG = new RelayCommand(param => Execute_AnwendenG(), param => CanExecute_AnwendenG());

            //Sold
            soldItemAdd = new RelayCommand(param => Execute_soldItemAdd(), param => CanExecute_soldItemAdd());

            //Got
            gotItemAdd = new RelayCommand(param => Execute_gotItemAdd(), param => CanExecute_gotItemAdd());

            gegebenContents.Add(gegebenAlle);
            gegebenContents.Add(gegebenEdit);

            bekommenContents.Add(bekommenAlle);
            bekommenContents.Add(bekommenEdit);

            CurrentGContent = gegebenContents[0];
            CurrentBContent = bekommenContents[0];
        }

        #endregion

        #region Commands

        /// <summary>
        /// Execute AnwendenB
        /// </summary>
        public void Execute_AnwendenB()
        {
            CurrentBContent = bekommenContents[0];
        }

        /// <summary>
        /// Can Execute AnwendenB
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_AnwendenB()
        {
            if (true)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Execute AnwendenG
        /// </summary>
        public void Execute_AnwendenG()
        {
            CurrentGContent = gegebenContents[0];
        }

        /// <summary>
        /// Can Execute AnwendenG
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_AnwendenG()
        {
            if (true)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Execute soldItemAdd
        /// </summary>
        public void Execute_soldItemAdd()
        {
            SoldItems.Add(new Item());
        }

        /// <summary>
        /// Ob Item Hinzugefügt werden kann (Gegeben)
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_soldItemAdd()
        {
            if (SoldItems.Count < 12)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Execute SaveTrade
        /// </summary>
        public void Execute_SaveTrade()
        {
            EditTrade.Date = DateTime.Now;
            TradeMocking.allTrades.Add(currentTrade);

            EditTrade = new Trade();
            SoldItems = new ObservableCollection<Item>();
            GotItems = new ObservableCollection<Item>();
            SoldItems.Add(new Item());
            GotItems.Add(new Item());

            MessageBox.Show("Trade gespeichert", "Erfolg", MessageBoxButton.OK, MessageBoxImage.None);
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
            return false;
        }


        /// <summary>
        /// Execute gotItemAdd
        /// </summary>
        public void Execute_gotItemAdd()
        {
            GotItems.Add(new Item());
        }

        /// <summary>
        /// Ob Item Hinzugefügt werden kann (Bekommen)
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_gotItemAdd()
        {
            if (GotItems.Count < 12)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
