using Microsoft.Extensions.DependencyInjection;
using WMSFePI;
using WMSFrontEnd;

namespace Comm.Net.Service;

public class BaseConnectContains
{
    private IServiceProvider serviceProvider;

    public WMSFePISoap WMSFePI => serviceProvider.GetService<WMSFePISoap>();
    public WMSFrontEndSoap WMSFrontEnd => serviceProvider.GetService<WMSFrontEndSoap>();

    public BaseConnectContains()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<WMSFePISoap>(new WMSFePISoapClient(WMSFePISoapClient.EndpointConfiguration.WMSFePISoap));
        serviceCollection.AddSingleton<WMSFrontEndSoap>(new WMSFrontEndSoapClient(WMSFrontEndSoapClient.EndpointConfiguration.WMSFrontEndSoap));
        serviceProvider = serviceCollection.BuildServiceProvider();
    }
}
