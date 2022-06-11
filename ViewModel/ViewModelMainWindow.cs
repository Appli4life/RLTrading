

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mime;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using ListBoxMVVM.ViewModels;
using RLTrading.Utility;

namespace RLTrading.ViewModel
{
    public class ViewModelMainWindow : ViewModelBase
    {
        public RelayCommand CloseApp { get; set; }
        public RelayCommand AllTradeSwitch { get; set; }
        public RelayCommand NewTradeSwitch { get; set; }
        public RelayCommand SaveCommand { get; set; }

        private ObservableCollection<ContentControl> contents = new ObservableCollection<ContentControl>();
        private AllTrade allTrade = new AllTrade();
        private NewTrade newTrade = new NewTrade();

        private ContentControl currentContent;


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

        public ContentControl Content
        {
            get => currentContent;
            set => SetProperty(ref currentContent, value);
        }

        private void Execute_Close()
        {
            Application.Current.Shutdown();
        }

        private bool canExecute_Close()
        {
            if (true)
            {
                return true;
            }
        }
        private void Execute_AllTrade()
        {
            Content = contents[0];
        }

        private bool canExecute_AllTrade()
        {
            if (true)
            {
                return true;
            }
        }
        private void Execute_NewTrade()
        {
            Content = contents[1];
        }

        private bool canExecute_NewTrade()
        {
            if (true)
            {
                return true;
            }
        }
        private void Execute_Save()
        {
            ViewModelAllTrade viemodel = (ViewModelAllTrade)allTrade.DataContext;
            viemodel.TradeSaver.saveTrades(viemodel.AllTrades);
        }

        private bool canExecute_Save()
        {
            if (true)
            {
                return true;
            }
        }
    }
}
