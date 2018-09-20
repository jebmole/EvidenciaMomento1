using Momento1_JEB.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Momento1_JEB
{
    public partial class App : Application
    {
        public App()
        {
#if DEBUG
            LiveReload.Init();
#endif

            InitializeComponent();

            MainPage = new NavigationPage(new TelefonoPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
