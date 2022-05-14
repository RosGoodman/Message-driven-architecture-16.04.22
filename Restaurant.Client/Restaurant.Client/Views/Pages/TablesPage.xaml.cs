using Ninject;
using Restaurant.Client.IoC;
using Restaurant.Client.ViewModel.ViewModels;
using System.Windows.Controls;

namespace Restaurant.Client.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для TablesPage.xaml
    /// </summary>
    public partial class TablesPage : Page
    {
        public TablesPage()
        {
            InitializeComponent();
            this.DataContext = ViewsIoC.Kernel.Get<TablesViewModel>();
        }
    }
}
