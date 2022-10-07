using System.Windows;
using System.Windows.Controls;
using RLTrading.ViewModel;

namespace RLTrading.View
{
    /// <summary>
    /// Interaction logic for BekommenAlleItems.xaml
    /// </summary>
    public partial class BekommenAlleItems : UserControl
    {
        public BekommenAlleItems()
        {
            this.InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var dataContext = (ViewModelNewTrade)this.DataContext;
            dataContext.CurrentBContent = dataContext.bekommenContents[1];
            dataContext.BEditItem = dataContext.SelectedItem;
        }

        private void MenuItem_OnClick2(object sender, RoutedEventArgs e)
        {
            var dataContext = (ViewModelNewTrade)this.DataContext;
            dataContext.GotItems.Remove(dataContext.SelectedItem);
        }
    }
}
