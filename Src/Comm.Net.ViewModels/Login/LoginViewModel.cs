using System.Data;
using Comm.Net.Models;
using Comm.Net.Models.User;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ITransformation;
using LocalStorage;
using MauiPocUnit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using Transformation;
using Transformation.WMSFrontEndSoapTran;
using LoginNS = Comm.Net.Models.Login;

namespace Comm.Net.ViewModels.Login;

public partial class LoginViewModel : ObservableObject
{
    #region 第一种方式

    //private string userName = string.Empty;

    //private string entryLabel = string.Empty;

    //public string UserName
    //{
    //    get => userName;
    //    set => SetProperty(ref userName, value);
    //}

    //public string EntryLabel
    //{
    //    get => entryLabel;
    //    set => SetProperty(ref entryLabel, value);
    //}

    //public IWMSFePISoapTran<LoginNS.Login, UserInfo> wMSFePI;

    //public LoginViewModel()
    //{
    //    wMSFePI = new WMSFePISoapTran();
    //}

    //private RelayCommand relayCommand;
    //public RelayCommand RelayCommand =>
    //relayCommand ??= new RelayCommand(() => UserName = "11111111111111");

    //private string _selectedColor;

    //public List<string> Colors { get; set; } = new List<string>
    //    {
    //        "Red", "Green", "Blue"
    //    };

    //public string SelectedColor
    //{
    //    get => _selectedColor;
    //    set => SetProperty(ref _selectedColor, value);
    //}
    #endregion

#nullable enable
    [ObservableProperty]
    private string? userName;

    [ObservableProperty]
    private string? passWord;

    [ObservableProperty]
    private string? loginEnvironment;

    [ObservableProperty]
    private string? versionNum = "1.7";

    [ObservableProperty]
    private string? instance;

    [ObservableProperty]
    private bool isChecked = InitLogin().Item1;

    [ObservableProperty]
    private string selectedItem = InitLogin().Item2;

    [ObservableProperty]
    public List<string> items;
#nullable disable

    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    public IWMSFePISoapTran<LoginNS.Login, UserInfo> wMSFePI;

    public IWMSFrontEndSoapTran<LoginNS.Login, UserInfo> wMSFrontEnd;

    private IDialogService dialogService;

    public LoginViewModel()
    {
        wMSFePI = new WMSFePISoapTran();
        wMSFrontEnd = new WMSFrontEndSoapTran();
        dialogService = new DialogService();
        Items = new List<string> { "UAT", "FUAT", "Item 3" };
    }

    public async void dialogShow(DialogModel dialog)
    {
        await dialogService.ShowAlert(dialog);
        return;
    }

    [RelayCommand]
    public async void UserLogin()
    {
        // 保存当前版本号
        // SrorageSingleton.Instance.Set("PDAVersion", VersionTracking.Default.CurrentVersion);
        var dialog = new DialogModel();
        dialog.Title = "Alter";
        dialog.ButtonLabel = "OK";
        if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(PassWord))
        {
            dialog.Message = "Please enter Login name or password";
            dialogShow(dialog);
        }

        var login = new LoginNS.Login();
        login.Instance = SelectedItem;
        login.UserName = UserName;
        try
        {
            var curVersion = await wMSFePI.getCurrentVersionAsync(login);
            if (curVersion != VersionNum)
            {
                dialog.Message = "Current version is not updated";
                dialogShow(dialog);
            }

            login.PassWord = await wMSFrontEnd.getPasswordAsync(login);
            if (login.PassWord != null && login.PassWord.ToUpper().Equals(PassWord.ToUpper()))
            {
                DataTable dt = new DataTable();
                var userInfo = wMSFrontEnd.getUserInfoAsync(login);

                //选中Remember 保存当前登录人信息
                if (IsChecked)
                {
                    SrorageSingleton.Instance.Set("CurrUserInfo", JsonConvert.SerializeObject(login));
                }
            }
            else
            {
                dialog.Message = "Please enter the correct password.";
                dialogShow(dialog);
            }
        }
        catch (Exception ex)
        {
            dialog.Message = "Cannot connect to internet.";
            dialogShow(dialog);
        }

        //选中Remember 保存当前登录人信息
        if (IsChecked)
        {
            SrorageSingleton.Instance.Set("CurrUserInfo", JsonConvert.SerializeObject(login));
        }

        await Shell.Current.GoToAsync($"//MainPage");
    }

    [RelayCommand]
    public void Clear()
    {
        UserName = string.Empty;
        PassWord = string.Empty;
        IsChecked = false;
        SrorageSingleton.Instance.Remove("CurrUserInfo");
    }

    /// <summary>
    /// 初始化登录
    /// </summary>
    /// <returns></returns>
    private static Tuple<bool, string> InitLogin()
    {
        if (string.IsNullOrWhiteSpace(SrorageSingleton.Instance.Get("CurrUserInfo", "")))
        {
            JObject jObject = JObject.Parse(SrorageSingleton.Instance.Get("CurrUserInfo", ""));
            string instance = (string)jObject["Instance"];
            var resTup = new Tuple<bool, string>(true, instance);

            return resTup;
        }

        return new Tuple<bool, string>(false, "UAT");
    }
}
