using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using RLTrading.Model;
using RLTrading.Utility;
using RLTrading.View;
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
        public ObservableCollection<ContentControl> GegebenContents = new();

        /// <summary>
        /// Aktueller gegeben Content
        /// </summary>
        private ContentControl currentGegebenContent;

        /// <summary>
        /// Collection von bekommen ContentControls
        /// </summary>
        public ObservableCollection<ContentControl> BekommenContents = new();

        /// <summary>
        /// Aktueller bekommen Content
        /// </summary>
        private ContentControl currentBekommenContent;

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
            get => this.currentGegebenContent;
            set => this.SetProperty(ref this.currentGegebenContent, value);
        }

        /// <summary>
        /// Accessor für Current bekommen Content
        /// </summary>
        public ContentControl CurrentBContent
        {
            get => this.currentBekommenContent;
            set => this.SetProperty(ref this.currentBekommenContent, value);
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
        public IEnumerable<Color> AllBrushes => ColorMocking.GetColors();

        /// <summary>
        /// Alle Zertifizierungen für Items
        /// </summary>
        public IEnumerable<Certification> AllCertifications => CertificationMocking.GetCertifications();

        /// <summary>
        /// Alle Qualitäten für Items
        /// </summary>
        public IEnumerable<Quality> AllQualities => QualityMocking.GetQuality();

        /// <summary>
        /// Accessor für neuer Trade
        /// </summary>
        public Trade EditTrade
        {
            get => this.currentTrade;
            set => this.SetProperty(ref this.currentTrade, value);
        }

        /// <summary>
        /// Accessor für alle Verkauften Items
        /// </summary>
        public ObservableCollection<Item> SoldItems
        {
            get => this.EditTrade.SoldItems;
            set => this.SetProperty(ref this.EditTrade.SoldItems, value);
        }

        /// <summary>
        /// Accessor für alle Gekauften Items
        /// </summary>
        public ObservableCollection<Item> GotItems
        {
            get => this.EditTrade.BoughtItems;
            set => this.SetProperty(ref this.EditTrade.BoughtItems, value);
        }

        /// <summary>
        /// Gegeben Item Hinzufügen
        /// </summary>
        public RelayCommand SoldItemAdd { get; set; }

        /// <summary>
        /// Bekommen Item Hinzufügen
        /// </summary>
        public RelayCommand GotItemAdd { get; set; }

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
            get => this.selectedItem;
            set => this.SetProperty(ref this.selectedItem, value);
        }

        /// <summary>
        /// Accessor für GEditItem
        /// </summary>
        public Item GEditItem
        {
            get => this.editedGItem;
            set => this.SetProperty(ref this.editedGItem, value);
        }

        /// <summary>
        /// Accessor für BEditItem
        /// </summary>
        public Item BEditItem
        {
            get => this.editedBItem;
            set => this.SetProperty(ref this.editedBItem, value);
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
            this.SoldItems.Add(new Item());
            this.GotItems.Add(new Item());

            this.AnwendenB = new RelayCommand(param => this.Execute_AnwendenB(), param => this.CanExecute_AnwendenB());
            this.AnwendenG = new RelayCommand(param => this.Execute_AnwendenG(), param => this.CanExecute_AnwendenG());

            //Sold
            this.SoldItemAdd = new RelayCommand(param => this.Execute_soldItemAdd(), param => this.CanExecute_soldItemAdd());

            //Got
            this.GotItemAdd = new RelayCommand(param => this.Execute_gotItemAdd(), param => this.CanExecute_gotItemAdd());

            this.GegebenContents.Add(this.gegebenAlle);
            this.GegebenContents.Add(this.gegebenEdit);

            this.BekommenContents.Add(this.bekommenAlle);
            this.BekommenContents.Add(this.bekommenEdit);

            this.CurrentGContent = this.GegebenContents[0];
            this.CurrentBContent = this.BekommenContents[0];
        }

        #endregion

        #region Commands

        /// <summary>
        /// Execute AnwendenB
        /// </summary>
        public void Execute_AnwendenB()
        {
            this.CurrentBContent = this.BekommenContents[0];
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
            this.CurrentGContent = this.GegebenContents[0];
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
            this.SoldItems.Add(new Item());
        }

        /// <summary>
        /// Ob Item Hinzugefügt werden kann (Gegeben)
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_soldItemAdd()
        {
            if (this.SoldItems.Count < 12)
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
            this.GotItems.Add(new Item());
        }

        /// <summary>
        /// Ob Item Hinzugefügt werden kann (Bekommen)
        /// </summary>
        /// <returns>True / False</returns>
        public bool CanExecute_gotItemAdd()
        {
            if (this.GotItems.Count < 12)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
