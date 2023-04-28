using Comm.Net.Models;
using Comm.Net.Models.Login;
using Comm.Net.Models.User;
using Comm.Net.Service;
using ITransformation;

namespace Transformation;

public class WMSFePISoapTran : BaseConnectContains, IWMSFePISoapTran<Login, UserInfo>
{
    /// <summary>
    /// 获取版本号
    /// </summary>
    /// <param name="login">登录信息</param>
    /// <returns>版本号</returns>
    public async Task<string> getCurrentVersionAsync(Login login)
    {
        var version = await base.WMSFePI.getCurrentVersionAsync(login.Instance);
        return version;
    }


    public Task<IBaseOutput> getPackingSearchAsync(Login input)
    {
        throw new NotImplementedException();
    }

    public Task<IBaseOutput> getPIConfigAsync(Login input)
    {
        throw new NotImplementedException();
    }

    public Task<IBaseOutput> getPIDetailAsync(Login input)
    {
        throw new NotImplementedException();
    }

    public Task<IBaseOutput> getPIRecAsync(Login input)
    {
        throw new NotImplementedException();
    }

    public Task<string> HelloWorldAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IBaseOutput> updatePIAsync(Login input)
    {
        throw new NotImplementedException();
    }

    public Task<IBaseOutput> validatePIAsync(Login input)
    {
        throw new NotImplementedException();
    }
}
