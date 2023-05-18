using NLog;

namespace MauiPocTest.Views.Login;

public partial class LoginPage : ContentPage
{


    public LoginPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        logger.Info("This is an information message.");
        //NLogUtils.WriteFileLog(NLog.LogLevel.Error, LogType.Web, "Web", "Web有异常，请检查代码。");
    }
}