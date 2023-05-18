/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：18/5/2023 11:44:06
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using LocalStorage;

namespace Comm.Net.ViewModels.Login
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }

        /// <summary>
        /// 检查有没有登录
        /// </summary>
        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = SrorageSingleton.Instance.Get("CurrUserInfo", "");

            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                //await Shell.Current.GoToAsync($"//LoginPage");
                await Shell.Current.GoToAsync($"Login/LoginPage");
            }
            else
            {
                await Shell.Current.GoToAsync($"Login/MainPage");
            }
        }
    }
}
