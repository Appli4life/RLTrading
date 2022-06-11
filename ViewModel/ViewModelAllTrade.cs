using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListBoxMVVM.ViewModels;
using RLTrading.Model;
using RLTrading.Utility;

namespace RLTrading.ViewModel
{
    public class ViewModelAllTrade : ViewModelBase
    {
        public JsonSaver TradeSaver = new JsonSaver();
        private ObservableCollection<Trade> allTrades;
        public RelayCommand SaveCommand { get; set; }

        public ViewModelAllTrade()
        {
            allTrades = new ObservableCollection<Trade>(TradeSaver.loadTrades());
            SaveCommand = new RelayCommand(param => Execute_Save(), param => canExecute_Save());
        }

        public ObservableCollection<Trade> AllTrades
        {
            get => allTrades;
            set => allTrades = value;
        }
        private void Execute_Save()
        {
            TradeSaver.saveTrades(allTrades);
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
