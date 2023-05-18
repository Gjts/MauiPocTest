/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：15/5/2023 16:26:27
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using CommunityToolkit.Mvvm.Input;

namespace Comm.Net.ViewModels;

public partial class MainPageViewModel
{
    [RelayCommand]
    public async void GoToUnloadMainPage() => await Shell.Current.GoToAsync($"Inventory/Unload/MainPage");

    [RelayCommand]
    public async void GoToPutAwayMainPage() => await Shell.Current.GoToAsync($"Inventory/PutAway/MainPage");

    [RelayCommand]
    public async void GoToRmaUnloadMainPage() => await Shell.Current.GoToAsync($"Inventory/RmaUnload/MainPage");

    [RelayCommand]
    public async void GoToRmaPutAwayMainPage() => await Shell.Current.GoToAsync($"Inventory/RmaPutAway/MainPage");

}
