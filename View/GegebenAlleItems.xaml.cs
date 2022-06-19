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

namespace RLTrading.View
{
    /// <summary>
    /// Interaction logic for GegebenAlleItems.xaml
    /// </summary>
    public partial class GegebenAlleItems : UserControl
    {
        public GegebenAlleItems()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var dataContext = (ViewModelNewTrade)this.DataContext;
            dataContext.CurrentGContent = dataContext.gegebenContents[1];
            dataContext.GEditItem = dataContext.SelectedItem;
        }

        private void MenuItem_OnClick2(object sender, RoutedEventArgs e)
        {
            var dataContext = (ViewModelNewTrade)this.DataContext;
            dataContext.SoldItems.Remove(dataContext.SelectedItem);
        }
    }
}
