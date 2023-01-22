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
            InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var context = this.DataContext as ViewModelAllTrade;
            context.OnEdit();
        }

        private void MenuItem_OnClick2(object sender, RoutedEventArgs e)
        {

            var context = this.DataContext as ViewModelAllTrade;
            context.OnDelete();
        }
    }
}
