using System.Windows.Controls;
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
            this.InitializeComponent();
            var data = new ViewModelNewTrade();
            this.DataContext = data;
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
