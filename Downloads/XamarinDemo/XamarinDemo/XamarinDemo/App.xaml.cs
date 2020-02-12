using Prism;
using Prism.Ioc;
using XamarinDemo.Constants;
using XamarinDemo.Screens;
using XamarinDemo.Screens.LearnCommand;
using XamarinDemo.Screens.Menus;
using XamarinDemo.Screens.WebViews;
using XamarinDemo.ViewModels;
using XamarinDemo.ViewModels.LearnCommand;
using XamarinDemo.ViewModels.Menus;
using XamarinDemo.ViewModels.WebViews;

namespace XamarinDemo
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

           await NavigationService.NavigateAsync($"{PageConst.NAVIGATION_PAGE}/{PageConst.MENU_MAIN_PAGE}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Xamarin.Forms.NavigationPage>(PageConst.NAVIGATION_PAGE);
            containerRegistry.RegisterForNavigation<MenuMainPage, MenuMainVM>(PageConst.MENU_MAIN_PAGE);
            containerRegistry.RegisterForNavigation<MenuWebViewPage, MenuWebViewVM>(PageConst.MENU_WEBVIEW_PAGE);
            containerRegistry.RegisterForNavigation<MenuLearnCommandPage, MenuLearnCommandVM>(PageConst.MENU_LEARNCOMMAND_PAGE);

            //webview
            containerRegistry.RegisterForNavigation<WebViewHybridPage, WebViewHybridVM>(PageConst.WEBVIEW_HYBRID_PAGE);

            //command
            containerRegistry.RegisterForNavigation<LearnCommandPage,LearnCommandVM>(PageConst.LEARN_COMMAND_PAGE);




        }
    }
}
