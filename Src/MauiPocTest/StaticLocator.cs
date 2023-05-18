using Comm.Net.ViewModels;
using Comm.Net.ViewModels.Inventory.PutAway;
using Comm.Net.ViewModels.Inventory.RmaPutAway;
using Comm.Net.ViewModels.Inventory.RmaUnload;
using Comm.Net.ViewModels.Inventory.Unload;
using MauiPocUnit;

namespace MauiPocTest;

public class StaticLocator
{
    private IServiceProvider _serviceProvider;

    public DialogService dialogService => _serviceProvider.GetService<DialogService>();

    public MainPageViewModel mainPageViewModel => _serviceProvider.GetService<MainPageViewModel>();

    #region Inventory
    public UnloadMainViewModel unloadMainViewModel => _serviceProvider.GetService<UnloadMainViewModel>();
    public PutAwayMainViewModel putAwayMainViewModel => _serviceProvider.GetService<PutAwayMainViewModel>();
    public RmaUnloadMainViewModel rmaUnloadMainViewModel => _serviceProvider.GetService<RmaUnloadMainViewModel>();
    public RmaPutAwayMainViewModel rmaPutAwayMainViewModel => _serviceProvider.GetService<RmaPutAwayMainViewModel>();
    #endregion

    public StaticLocator()
    {
        var serviceCollection = new ServiceCollection();

        // 注册对话框服务
        serviceCollection.AddSingleton<DialogService>();
        serviceCollection.AddSingleton<MainPageViewModel>();
        #region Inventory
        serviceCollection.AddSingleton<UnloadMainViewModel>();
        serviceCollection.AddSingleton<PutAwayMainViewModel>();
        serviceCollection.AddSingleton<RmaUnloadMainViewModel>();
        serviceCollection.AddSingleton<RmaPutAwayMainViewModel>();
        #endregion

        _serviceProvider = serviceCollection.BuildServiceProvider();
    }
}
