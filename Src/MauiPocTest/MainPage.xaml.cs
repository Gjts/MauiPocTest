namespace MauiPocTest
{
    public partial class MainPage : ContentPage
    {
        private IServiceProvider serviceProvider;

        //public WMSFePISoap WMSFePI => serviceProvider.GetService<WMSFePISoap>();
        //public WMSFrontEndSoap WMSEndFront => serviceProvider.GetService<WMSFrontEndSoap>();
        //private IWMSFePISoapTran<Login, UserInfo> wMSFePISoapTran;
        //private IWMSFrontEndSoapTran<Login, UserInfo> wMSFrontEndSoapTran;
        public MainPage()
        {
            //this.wMSFePISoapTran = new WMSFePISoapTran();
            //this.wMSFrontEndSoapTran = new WMSFrontEndSoapTran();

            InitializeComponent();
            //GetSersion();
            //GETOO();
        }


        //public async void GETOO()
        //{
        //    //var hasNewVersion = await VersionTracking.CheckForUpdatesAsync();
        //    //if (hasNewVersion)
        //    //{
        //    //    // 显示更新提示框
        //    //    VersionTracking.ShowUpdatePrompt();
        //    //}
        //    var login = new Login();
        //    login.Instance = "UAT";
        //    login.UserName = "HARDIEBAO";
        //    //var user = await wMSFrontEndSoapTran.getUserInfoAsync(login);

        //}

        //public async void GetSersion()
        //{
        //    //var currentVersion = await WMSFePI.getCurrentVersionAsync("UAT");
        //    //var loginStatus = await WMSEndFront.getPasswordAsync("UAT", "HardieBao");
        //    //var userInfo = await wMSFrontEndSoapTran.getUserInfoAsync("UAT", "HardieBao");
        //    //var result = ToDataSet(userInfo);

        //}

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    //bool result = await DisplayAlert("提示", "你确定要执行此操作吗？", "是", "否");

        //    //if (result)
        //    //{
        //    //    // 用户选择了“是”
        //    //}
        //    //else
        //    //{
        //    //    // 用户选择了“否”
        //    //}
        //    //may.DisplayAlert("Alert", "You have been alerted", "OK");
        //}

        //public DataSet ToDataSet(ArrayOfXElement arrayOfXElement)
        //{
        //    var strSchema = arrayOfXElement.Nodes[0].ToString();
        //    var strData = arrayOfXElement.Nodes[1].ToString();
        //    var strXml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n\t<DataSet>";
        //    strXml += strSchema + strData;
        //    strXml += "</DataSet>";

        //    DataSet ds = new DataSet("TemptDataSet");
        //    ds.ReadXml(new MemoryStream(Encoding.UTF8.GetBytes(strXml)));

        //    return ds;
        //}
    }
}