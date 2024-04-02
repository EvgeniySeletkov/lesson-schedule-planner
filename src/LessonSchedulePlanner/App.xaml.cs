using LessonSchedulePlanner.ViewModels;
using LessonSchedulePlanner.Views;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace LessonSchedulePlanner
{
    public partial class App : PrismApplication
    {
        public App()
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(SchedulePage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Pages
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<SchedulePage, SchedulePageViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
