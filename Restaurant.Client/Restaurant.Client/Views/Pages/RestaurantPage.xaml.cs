using Ninject;
using Restaurant.Client.IoC;
using Restaurant.Client.ViewModel.ViewModels;
using System.Windows.Controls;

namespace Restaurant.Client.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RestaurantPage.xaml
    /// </summary>
    public partial class RestaurantPage : Page
    {
        private RestaurantViewModel _viewModel;

        public RestaurantPage()
        {
            InitializeComponent();
            _viewModel = ViewsIoC.Kernel.Get<RestaurantViewModel>();
            this.DataContext = _viewModel;
        }
    }
}
