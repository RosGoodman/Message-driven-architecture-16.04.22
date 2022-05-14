using Ninject;
using Restaurant.Client.IoC;
using Restaurant.Client.ViewModel;
using Restaurant.Client.ViewModel.IoC;
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
            var mainVM = ViewModelIoC.Kernel.Get<MainWindowViewModel>();

            Current.MainWindow = new MainWindow() { DataContext = mainVM };
            Current.MainWindow.Show();
        }
    }
}
