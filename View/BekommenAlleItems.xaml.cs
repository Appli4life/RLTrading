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
    /// Interaction logic for BekommenAlleItems.xaml
    /// </summary>
    public partial class BekommenAlleItems : UserControl
    {
        public BekommenAlleItems()
        {
            InitializeComponent();
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
