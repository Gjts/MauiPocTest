/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：12/5/2023 12:17:32
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using CommunityToolkit.Mvvm.Input;

namespace Comm.Net.ViewModels.AppShell;

public partial class AppShellViewModel
{

    [RelayCommand]
    public async void SignOut()
    {
        //if (Preferences.ContainsKey("CurrUserInfo"))
        //{
        //    Preferences.Remove("CurrUserInfo");
        //}

        await Shell.Current.GoToAsync($"//LoginPage");
    }
}
