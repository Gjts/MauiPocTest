using System.Data;
using Comm.Net.Models;
using Comm.Net.Models.User;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ITransformation;
using MauiPocUnit;
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
    //    relayCommand ??= new RelayCommand(() => UserName = "11111111111111");
    #endregion

    [ObservableProperty]
    private string? userName;

    [ObservableProperty]
    private string? passWord;

    [ObservableProperty]
    private string? loginEnvironment;

    [ObservableProperty]
    private string? versionNum;

    [ObservableProperty]
    private string? instance;

    [ObservableProperty]
    private string? isLogin;

    public IWMSFePISoapTran<LoginNS.Login, UserInfo> wMSFePI;

    public IWMSFrontEndSoapTran<LoginNS.Login, UserInfo> wMSFrontEnd;

    private IDialogService dialogService;

    public LoginViewModel()
    {
        wMSFePI = new WMSFePISoapTran();
        wMSFrontEnd = new WMSFrontEndSoapTran();
        dialogService = new DialogService();
    }

    public async void dialogShow(DialogModel dialog)
    {
        await dialogService.ShowAlert(dialog);
        return;
    }

    private string _selectedColor;

    public List<string> Colors { get; set; } = new List<string>
        {
            "Red", "Green", "Blue"
        };

    public string SelectedColor
    {
        get => _selectedColor;
        set => SetProperty(ref _selectedColor, value);
    }
    
    [RelayCommand]
    public async void UserLogin()
    {
        var dialog = new DialogModel();
        dialog.Title = "Alter";
        dialog.ButtonLabel = "OK";
        if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(PassWord))
        {
            dialog.Message = "Please enter Login name or password";
            dialogShow(dialog);
        }

        var login = new LoginNS.Login();
        login.Instance = "UAT";
        login.UserName = UserName;
        try
        {
            var curVersion = await wMSFePI.getCurrentVersionAsync(login);
            if (curVersion != VersionNum)
            {
                dialog.Message = "Current version is not updated";
                return;
            }

            string password = await wMSFrontEnd.getPasswordAsync(login);
            if (password != null && password.ToUpper().Equals(PassWord.ToUpper()))
            {
                DataTable dt = new DataTable();
                var userInfo = wMSFrontEnd.getUserInfoAsync(login);
            }
            else
            {
                dialog.Message = "Please enter the correct password.";
            }
        }
        catch (Exception ex)
        {
            dialog.Message = "Cannot connect to internet.";
        }

        dialog.Message = "Please enter the correct password.";
        dialog.Title = "ASucessfal Login";
        dialog.ButtonLabel = "OK";
        dialogShow(dialog);
    }
}
