using System.Windows;
using System.Windows.Controls;
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
            this.InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var datacontext = (ViewModelAllTrade)this.DataContext;
            var mainDatacontext = (ViewModelMainWindow)Application.Current.MainWindow.DataContext;
            mainDatacontext.Content = mainDatacontext.contents[1];
            var newTradeDataContext = (ViewModelNewTrade)mainDatacontext.newTrade.DataContext;

            newTradeDataContext.EditTrade = datacontext.SelectedTrade;
            newTradeDataContext.SoldItems = new(datacontext.SelectedTrade.soldItems);
            newTradeDataContext.GotItems = new(datacontext.SelectedTrade.boughtItems);

            datacontext.AllTrades.Remove(datacontext.SelectedTrade);

        }

        private void MenuItem_OnClick2(object sender, RoutedEventArgs e)
        {
            var datacontext = (ViewModelAllTrade)this.DataContext;
            datacontext.AllTrades.Remove(datacontext.SelectedTrade);
        }
    }
}
