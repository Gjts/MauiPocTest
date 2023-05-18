/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：17/5/2023 9:49:31
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/

namespace LocalStorage;

public class SrorageSingleton
{
    /// <summary>
    /// 延迟实例化 WMSFrontEndSoapTran 对象 Lazy 是线程安全的
    /// </summary>
    private static readonly Lazy<PreferenceStorage> _lazyInstance =
        new Lazy<PreferenceStorage>(() => new PreferenceStorage());

    /// <summary>
    /// 获取服务实例
    /// </summary>
    public static PreferenceStorage Instance { get { return _lazyInstance.Value; } }
}
