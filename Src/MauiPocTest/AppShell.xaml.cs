using Comm.Net.ViewModels.AppShell;

namespace MauiPocTest
{
    public partial class AppShell : Shell
    {

        public AppShell()
        {
            // 1. 初始化组件
            InitializeComponent();

            // 2.绑定AppShell
            this.BindingContext = new AppShellViewModel();
        }
    }
}