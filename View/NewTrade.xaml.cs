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
    /// Interaction logic for NewTrade.xaml
    /// </summary>
    public partial class NewTrade : UserControl
    {
        public NewTrade()
        {
            InitializeComponent();
            var data = new ViewModelNewTrade();
            DataContext = data;
            foreach (var content in data.gegebenContents)
            {
                content.DataContext = this.DataContext;
            }

            foreach (var content in data.bekommenContents)
            {
                content.DataContext = this.DataContext;
            }

        }
    }
}
