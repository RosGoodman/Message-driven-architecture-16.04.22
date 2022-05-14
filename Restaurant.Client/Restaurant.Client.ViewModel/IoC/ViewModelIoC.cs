
using Ninject;

namespace Restaurant.Client.ViewModel.IoC;

/// <summary> IoC для приложения. </summary>
public static class ViewModelIoC
{
    /// <summary> Kernel для IoC кортейнера. </summary>
    public static IKernel Kernel { get; private set; } = new StandardKernel();

    /// <summary> Настройкка IoC контейнера, привязка информации. </summary>
    public static void Setup()
    {
        BindViewModels();
        BindRepositories();
    }

    /// <summary> Bind all singletone VM. </summary>
    private static void BindViewModels()
    {
        Kernel.Bind<MainWindowViewModel>().ToSelf().InSingletonScope();
    }

    /// <summary> Bind all singletone Repositories. </summary>
    private static void BindRepositories()
    {

    }
}
