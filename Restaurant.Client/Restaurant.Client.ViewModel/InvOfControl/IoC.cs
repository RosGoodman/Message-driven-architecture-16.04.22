
using Ninject;
using Restaurant.Client.Model.DAL.DataContext;

namespace Restaurant.Client.ViewModel.InvOfControl;

/// <summary> IoC для приложения. </summary>
public static class IoC
{
    /// <summary> Kernel для IoC кортейнера. </summary>
    public static IKernel Kernel { get; private set; } = new StandardKernel();

    /// <summary> Настройкка IoC контейнера, привязка информации. </summary>
    public static void Setup()
    {
        Kernel.Bind<IContextDb>().To<ContextDb>();
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
