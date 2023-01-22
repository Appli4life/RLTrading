using System.Windows;
using System.Windows.Controls;
using RLTrading.ViewModel;

namespace RLTrading.View
{
    /// <summary>
    /// Interaction logic for GegebenAlleItems.xaml
    /// </summary>
    public partial class GegebenAlleItems : UserControl
    {
        public GegebenAlleItems()
        {
            this.InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var dataContext = (ViewModelNewTrade)this.DataContext;
            dataContext.CurrentGContent = dataContext.GegebenContents[1];
            dataContext.GEditItem = dataContext.SelectedItem;
        }

        private void MenuItem_OnClick2(object sender, RoutedEventArgs e)
        {
            var dataContext = (ViewModelNewTrade)this.DataContext;
            dataContext.SoldItems.Remove(dataContext.SelectedItem);
        }
    }
}
