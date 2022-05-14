using Ninject;
using Restaurant.Client.IoC;
using Restaurant.Client.ViewModel.IoC;
using Restaurant.Client.ViewModel.ViewModels;
using Restaurant.Client.Views.Windows;
using System.Windows;

namespace Restaurant.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary> Кастомный стартап. </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ViewsIoC.Setup();
            ViewModelIoC.Setup();

            Current.MainWindow = new MainWindow(); //ViewModelIoC.Kernel.Get<MainWindow>();
            Current.MainWindow.DataContext = ViewModelIoC.Kernel.Get<MainWindowViewModel>();
            Current.MainWindow.Show();

        }
    }
}
