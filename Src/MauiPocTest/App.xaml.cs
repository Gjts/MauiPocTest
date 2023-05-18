using MauiPocTest.BaseModel;

namespace MauiPocTest
{
    public partial class App : Application
    {
        public App()
        {
            // 1. 初始化组件
            InitializeComponent();

            // 2. 创建AppShell对象,并赋值给MainPage属性
            MainPage = new AppShell();

            // 3. 注册相对路由
            RegisterRoute();
        }

        /// <summary>
        /// 注册相对路由
        /// </summary>
        private void RegisterRoute()
        {
            foreach (var route in RouteTable.Routes)
            {
                Routing.RegisterRoute(route.Key, route.Value);
            }
        }
    }
}