using Ninject;
using Restaurant.Client.IoC;
using Restaurant.Client.Switcher;
using System.Windows;
using System.Windows.Controls;

namespace Restaurant.Client.Views.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, IMainWindowPageZone
{
    public ContentControl MainWindowPageZoneContent
    {
        get => MainPageZone;
        set
        {
            MainPageZone.Content = value;
        }
    }

    public MainWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Открыть страницу ресторанов.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OpenRestaurantPage_Click(object sender, RoutedEventArgs e)
    {
        var switcher = ViewsIoC.Kernel.Get<IPageSwitcher>();
        switcher.SwitchTo(PagesEnum.RestaurantPage);
    }

    /// <summary>
    /// Открыть страницу столиков.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OpenTablesPage_Click(object sender, RoutedEventArgs e)
    {
        var switcher = ViewsIoC.Kernel.Get<IPageSwitcher>();
        switcher.SwitchTo(PagesEnum.TablesPage);
    }
}
