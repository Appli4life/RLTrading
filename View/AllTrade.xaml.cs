using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RLTrading.ViewModel;

namespace RLTrading
{
    /// <summary>
    /// Interaction logic for AllTrade.xaml
    /// </summary>
    public partial class AllTrade : UserControl
    {
        public AllTrade()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var datacontext = (ViewModelAllTrade)DataContext;
            var mainDatacontext = (ViewModelMainWindow)Application.Current.MainWindow.DataContext;
            mainDatacontext.Content = mainDatacontext.contents[1];
            var newTradeDataContext = (ViewModelNewTrade)mainDatacontext.newTrade.DataContext;

            newTradeDataContext.EditTrade = datacontext.SelectedTrade;
            newTradeDataContext.SoldItems = new (datacontext.SelectedTrade.soldItems);
            newTradeDataContext.GotItems = new(datacontext.SelectedTrade.boughtItems);

            datacontext.AllTrades.Remove(datacontext.SelectedTrade);

        }

        private void MenuItem_OnClick2(object sender, RoutedEventArgs e)
        {
            var datacontext = (ViewModelAllTrade)DataContext;
            datacontext.AllTrades.Remove(datacontext.SelectedTrade);
        }
    }
}
