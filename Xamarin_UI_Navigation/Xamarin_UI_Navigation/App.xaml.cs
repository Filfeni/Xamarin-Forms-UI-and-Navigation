using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_UI_Navigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Login()) { BarBackgroundColor = Color.White, BarTextColor = Color.Black};
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
