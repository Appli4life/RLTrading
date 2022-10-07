using System.Windows;
using RLTrading.Model;

namespace RLTrading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TradeMocking tradeMocking;

        public MainWindow()
        {
            this.tradeMocking = new TradeMocking();
            this.InitializeComponent();
        }
    }
}
