using System.Runtime.ConstrainedExecution;
using MauiPocUnit;

namespace MauiPocTest;

public abstract class IconsLocator
{
    private IServiceProvider serviceProvider;

    public DialogService dialogService => serviceProvider.GetService<DialogService>();

    public IconsLocator()
    {
        var serviceCollection = new ServiceCollection();

        // 注册对话框服务
        serviceCollection.AddSingleton<DialogService>();
        serviceProvider = serviceCollection.BuildServiceProvider();
    }
}
