using lab08.Services;
using lab08.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab08
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            // MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
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
