using Comm.Net.Models;
using Comm.Net.Models.Login;
using Comm.Net.Models.User;
using Comm.Net.Service;
using Comm.Net.Utils;
using ITransformation;

namespace Transformation.WMSFrontEndSoapTran;

public class WMSFrontEndSoapTran : BaseConnectContains, IWMSFrontEndSoapTran<Login, UserInfo>
{
    public async Task<string> getPasswordAsync(Login login)
    {
        var password = await WMSFrontEnd.getPasswordAsync(login.Instance, login.UserName);
        return password;
    }

    public async Task<IBaseOutput> getUserInfoAsync(Login login)
    {
        var xmlArray = await WMSFrontEnd.getUserInfoAsync(login.Instance, login.UserName);
        var userInfo = WebServiceHelper.ParseFromXml(xmlArray);
        return userInfo;
    }
}