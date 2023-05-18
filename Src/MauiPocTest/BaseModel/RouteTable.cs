/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：15/5/2023 11:55:12
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using MauiPocTest.Views.Inventory.PutAway;
using MauiPocTest.Views.Inventory.RmaPutAway;
using MauiPocTest.Views.Inventory.RmaUnload;
using MauiPocTest.Views.Inventory.Unload;
using MauiPocTest.Views.Login;

namespace MauiPocTest.BaseModel
{
    public class RouteTable
    {
        public static Dictionary<string, Type> Routes = new Dictionary<string, Type>()
        {
            { "Login/LoginPage", typeof(LoginPage) },
            { "Login/MainPage", typeof(MainPage) },
            { "Inventory/Unload/MainPage", typeof(UploadMainIndex) },
            { "Inventory/PutAway/MainPage", typeof(PutAwayMainIndex) },
            { "Inventory/RmaPutAway/MainPage", typeof(RmaUnloadMainIndex) },
            { "Inventory/RmaUnload/MainPage", typeof(RmaPutAwayMainIndex) },
        };
    }
}
