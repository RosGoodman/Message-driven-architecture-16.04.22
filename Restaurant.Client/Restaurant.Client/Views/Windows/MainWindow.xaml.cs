using Restaurant.Client.Views.Windows;
using System.Windows;
using System.Windows.Controls;

namespace Restaurant.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowPageZone
    {
        public ContentControl MainWindowPageZoneContent
        {
            get => this.MainPageZone;
            set
            {
                MainPageZone.Content = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
