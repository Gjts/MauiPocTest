/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：15/5/2023 13:51:27
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using Comm.Net.Models.User;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Comm.Net.ViewModels.Inventory.Unload;

public partial class UnloadMainViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private UserInfo userinfo;
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        //userinfo = query["p1"] as UserInfo;
    }
}
