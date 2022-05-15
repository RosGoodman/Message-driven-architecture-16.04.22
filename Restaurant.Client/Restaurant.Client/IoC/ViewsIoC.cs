
using Ninject;
using Restaurant.Client.Switcher;
using Restaurant.Client.Views.Pages;
using Restaurant.Client.Views.Windows;

namespace Restaurant.Client.IoC;

/// <summary> Контейнер для Views. </summary>
internal static class ViewsIoC
{
    public static IKernel Kernel { get; private set; } = new StandardKernel();


    public static void Setup()
    {
        BindWindows();
        BindPages();
        BindPageSwitcher();
    }


    private static void BindPages()
    {
        Kernel.Bind<RestaurantPage>().ToSelf().InSingletonScope();
        Kernel.Bind<TablesPage>().ToSelf().InSingletonScope();
    }


    private static void BindWindows()
    {
        Kernel.Bind<MainWindow>().ToSelf().InSingletonScope();
    }

    private static void BindPageSwitcher()
    {
        Kernel.Bind<PageSwitcher>().ToSelf().InSingletonScope().
            WithConstructorArgument("mainWindow", Kernel.Get<MainWindow>());
    }
}