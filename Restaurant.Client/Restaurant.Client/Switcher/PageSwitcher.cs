
using Ninject;
using Restaurant.Client.IoC;
using Restaurant.Client.Views.Pages;
using Restaurant.Client.Views.Windows;

namespace Restaurant.Client.Switcher;

internal class PageSwitcher
{
    private IMainWindowPageZone _mainWindow;

    /// <summary> ctor. </summary>
    /// <param name="mainWindow"> MainWindow. </param>
    public PageSwitcher(IMainWindowPageZone mainWindow)
    {
        _mainWindow = mainWindow;
    }

    /// <summary> Переключить страницу. </summary>
    /// <param name="newPage"> Наименование новой страницы. </param>
    public void SwitchTo(PagesEnum newPage)
    {
        switch (newPage)
        {
            case PagesEnum.RestaurantPage:
                _mainWindow.MainWindowPageZoneContent.Content = ViewsIoC.Kernel.Get<RestaurantPage>();
                break;
            case PagesEnum.TablesPage:
                _mainWindow.MainWindowPageZoneContent.Content = ViewsIoC.Kernel.Get<TablesPage>();
                break;
        }
    }
}