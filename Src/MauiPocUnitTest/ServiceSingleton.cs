using Comm.Net.Models.Login;
using Comm.Net.Models.User;
using ITransformation;
using Transformation.WMSFrontEndSoapTran;

namespace MauiPocUnitTest;

public class ServiceSingleton
{
    /// <summary>
    /// 延迟实例化 WMSFrontEndSoapTran 对象 Lazy 是线程安全的
    /// </summary>
    private static readonly Lazy<IWMSFrontEndSoapTran<Login, UserInfo>> _lazyInstance = 
        new Lazy<IWMSFrontEndSoapTran<Login, UserInfo>>(() => new WMSFrontEndSoapTran());

    /// <summary>
    /// 获取服务实例
    /// </summary>
    public static IWMSFrontEndSoapTran<Login, UserInfo> Instance { get { return _lazyInstance.Value; } }
}
