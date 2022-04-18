using Ninject;
using Restaurant.Client.ViewModel;
using Restaurant.Client.ViewModel.InvOfControl;
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

            IoC.Setup();
            var mainVM = IoC.Kernel.Get<MainWindowViewModel>();

            Current.MainWindow = new MainWindow() { DataContext = mainVM };
            Current.MainWindow.Show();
        }
    }
}
