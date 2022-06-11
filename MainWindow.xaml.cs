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

namespace RLTrading
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Color> colors = new List<Color>() { new Color("Default"),
                new Color("Black"),
                new Color("White"),
                new Color("Grey"),
                new Color("Crimson"),
                new Color("Pink"),
                new Color("Cobalt"),
                new Color("Sky Blue"),
                new Color("Sienna"),
                new Color("Saffron"),
                new Color("Lime"),
                new Color("Green"),
                new Color("Orange"),
                new Color("Purple")};

        public List<Quality> qualities = new List<Quality>() { new Quality("Common"),
            new Quality("Uncommon"),
                new Quality("Rare"),
                new Quality("Very Rare"),
                new Quality("Import"),
                new Quality("Exotic"),
                new Quality("Black Market"),
                new Quality("Premium"),
                new Quality("Limited"),
                new Quality("Legacy")};

        public List<Certification> certifications = new List<Certification>() {new Certification("None"),
            new Certification("Striker"),
            new Certification("Sweeper"),
            new Certification("Tactician"),
            new Certification("Acrobat"),
            new Certification("Aviator"),
            new Certification("Goalkeeper"),
            new Certification("Guardian"),
            new Certification("Juggler"),
            new Certification("Playmaker"),
            new Certification("Scorer"),
            new Certification("Show-Off"),
            new Certification("Sniper"),
            new Certification("Turle"),
            new Certification("Paragon"),
            new Certification("Victor")};

        private List<ContentControl> Contents = new List<ContentControl>();
        AllTrade allTrade = new AllTrade();
        NewTrade newTrade = new NewTrade();
        
        private bool force = false;

        public MainWindow()
        {
            InitializeComponent();
            Contents.Add(allTrade);
            Contents.Add(newTrade);
            main.Content = Contents[0];

            if (!allTrade.tradeStorage.loadTrades())
            {
                if (MessageBoxResult.OK == MessageBox.Show("Something went wrong with loading\nthe trades. Please Contact Simon!\nApplication is going to shut down!", "Attention!", MessageBoxButton.OK, MessageBoxImage.Warning))
                {
                    force = true;
                    Application.Current.Shutdown();
                }
            }

        }

        private void allTrades_Click(object sender, RoutedEventArgs e)
        {
            main.Content = Contents[0];
        }

        private void NewTrade_Click(object sender, RoutedEventArgs e)
        {
            main.Content = Contents[1];
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!allTrade.tradeStorage.saveTrades())
            {
                if (!force && MessageBoxResult.Yes == MessageBox.Show("Something went wrong with saving your trades!\nStill want to close the Application?", "Attention", MessageBoxButton.YesNo, MessageBoxImage.Question))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
